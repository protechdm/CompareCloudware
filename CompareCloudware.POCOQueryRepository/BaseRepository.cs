using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Castle.Core.Logging;
//using System.Data.Objects;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;
using System.Data.Entity.Core;

namespace CompareCloudware.POCOQueryRepository
{
    public class BaseRepository
    {
        private readonly CompareCloudwareContext _requestLifeTimeContext;
        //private static readonly log4net.ILog Log =
        //    log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ILogger Logger { get; set; }


        public BaseRepository(CompareCloudwareContext casesContext)
        {
            this._requestLifeTimeContext = casesContext;
        }

        public bool Update<T>(string userId, T model) where T : class
        {
            return Update<T>(userId, model, RefreshMode.StoreWins);
        }

        public bool Update<T>(string userId, T model, RefreshMode refreshMode) where T : class
        {
            if (Logger != null)
            {
                Logger.DebugFormat(DateTime.Now.ToString() + " - Update({0}):{1}", userId, model.GetType());
            }
            bool insertStatus = false;

            try
            {
                //db.Entry(model).State = EntityState.Modified;
                _requestLifeTimeContext.Entry(model).State = EntityState.Modified;
                _requestLifeTimeContext.SaveChanges();
                insertStatus = true;
                //_requestLifeTimeContext.ObjectContext().Refresh(RefreshMode.StoreWins, model);
                //throw new Exception("Unable to save - ");
            }
            catch (OptimisticConcurrencyException ex)
            {
                if (Logger != null)
                {
                    Logger.Error("OPTIMISTIC CONCURRENCY EXCEPTION : " + ex.Message, ex);
                }
                //throw new Exception(DateTime.Now.ToString() + " - Unable to save - " + ex.Message);
                _requestLifeTimeContext.ObjectContext().Refresh(refreshMode, model);
                _requestLifeTimeContext.SaveChanges();
            }
            catch (System.Data.DBConcurrencyException ex)
            {
                if (Logger != null)
                {
                    Logger.Error("OPTIMISTIC CONCURRENCY EXCEPTION : " + ex.Message, ex);
                }
                //throw new Exception(DateTime.Now.ToString() + " - Unable to save - " + ex.Message);
                _requestLifeTimeContext.ObjectContext().Refresh(refreshMode, model);
                _requestLifeTimeContext.SaveChanges();

                
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
            {
                try
                {
                    _requestLifeTimeContext.ObjectContext().Refresh(refreshMode, model);
                    _requestLifeTimeContext.Entry(model).State = EntityState.Modified;
                    if (Logger != null)
                    {
                        Logger.Error("OPTIMISTIC CONCURRENCY EXCEPTION : " + ex.Message, ex);
                    }
                    foreach (System.Data.Entity.Infrastructure.DbEntityEntry entry in ex.Entries)
                    {
                        _requestLifeTimeContext.ObjectContext().Refresh(refreshMode, entry.Entity);
                        _requestLifeTimeContext.Entry(entry.Entity).State = EntityState.Modified;
                        if (Logger != null)
                        {
                            Logger.Error("OPTIMISTIC CONCURRENCY EXCEPTION CHILD : " + entry.Entity.ToString());
                        }
                    }
                    //_requestLifeTimeContext.ObjectContext().Refresh(System.Data.Objects.RefreshMode.ClientWins, model);
                    //_requestLifeTimeContext.Entry(model).State = EntityState.Modified;
                    _requestLifeTimeContext.SaveChanges();
                    insertStatus = true;
                }
                catch (Exception e)
                {
                    throw new System.Data.Entity.Infrastructure.DbUpdateConcurrencyException("RETRYING TO SAVE");
                    //Logger.Error("FATAL OPTIMISTIC CONCURRENCY EXCEPTION : " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                if (ex.InnerException.GetType() == typeof(OptimisticConcurrencyException))
                {
                    try
                    {
                        _requestLifeTimeContext.ObjectContext().Refresh(refreshMode, model);
                        _requestLifeTimeContext.Entry(model).State = EntityState.Modified;
                        
                        
                        _requestLifeTimeContext.SaveChanges();
                        insertStatus = true;
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException ex2)
                    {

                        if (Logger != null)
                        {
                            Logger.Error(ex.Message, ex);
                        }
                        throw new Exception(DateTime.Now.ToString() + " - Unable to save - " + ex.Message);
                    }
                }
            }
            return insertStatus;
        }

        public bool Delete<T>(string userId, T model) where T : class
        {

            Logger.DebugFormat("Delete({0}):{1}", userId, model.GetType());
            bool deleteStatus = false;

            try
            {
                //db.Entry(model).State = EntityState.Modified;
                _requestLifeTimeContext.Entry(model).State = EntityState.Deleted;
                _requestLifeTimeContext.SaveChanges();
                deleteStatus = true;
                //throw new Exception("Unable to save - ");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
                throw new Exception("Unable to delete - " + ex.Message);
            }
            return deleteStatus;
        }

        public bool Insert<T>(T model) where T : class
        {
            if (Logger != null)
            {
                Logger.DebugFormat("Insert({0}):{1}", model.GetType(), "");
            }
            bool insertStatus = false;

            try
            {
                using (var db = new CompareCloudwareContext())
                {
                    db.Entry(model).State = EntityState.Added;
                    db.SaveChanges();
                    insertStatus = true;
                    //db.ObjectContext().Refresh(System.Data.Objects.RefreshMode.ClientWins,model);
                }
            }
            catch (Exception ex)
            {
                if (Logger != null)
                {
                    Logger.Error(ex.Message, ex);
                }
            }
            return insertStatus;
        }

        public bool Insert<T>(string userId, T model) where T : class
        {
            Logger.DebugFormat("Insert({0}):{1}", userId, model.GetType());
            bool insertStatus = false;

            try
            {
                using (var db = new CompareCloudwareContext())
                {
                    db.Entry(model).State = EntityState.Added;
                    db.SaveChanges();
                    insertStatus = true;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
            return insertStatus;
        }

        public bool Insert<T>(T model, bool useSameContext) where T : class
        {
            if (Logger != null)
            {
                Logger.DebugFormat("Insert({0}):{1}", model.GetType(), "");
            }
            bool insertStatus = false;

            try
            {
                _requestLifeTimeContext.Entry(model).State = EntityState.Added;
                _requestLifeTimeContext.SaveChanges();
                insertStatus = true;
                //using (var db = new CompareCloudwareContext())

                //using (var db = _requestLifeTimeContext)
                //{
                //    db.Entry(model).State = EntityState.Added;
                //    db.SaveChanges();
                //    insertStatus = true;
                //    //db.ObjectContext().Refresh(System.Data.Objects.RefreshMode.ClientWins,model);
                //}
            }
            catch (Exception ex)
            {

                if (Logger != null)
                {
                    Logger.Error(ex.Message, ex);
                }
            }
            return insertStatus;
        }

    }
}



