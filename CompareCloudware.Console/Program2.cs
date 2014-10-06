using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompareCloudware.Domain.Models;
using CompareCloudware.POCOQueryRepository;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;

using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Shell;
using ManagedWinapi;
using GhostscriptSharp;
using System.Configuration;

namespace CompareCloudware.Console
{
    class Program2
    {

        static void Main(string[] args)
        {
            string TEST_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf";
            string SINGLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            string OUTPUT_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\";
            string MULTIPLE_FILE_LOCATION = "J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\output%d.jpg";
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CloudCompare.Domain.CloudCompareContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<CloudCompareContext>());
            //InsertVendor();
            //StageData();
            //LoadRatings();

            //using (var context = new CloudCompareContext())
            //{
            //    LoadTwitterFollowers(context);
            //    context.SaveChanges();
            //}

            //using (var context = new CloudCompareContext())
            //{
            //    LoadFacebookFans(context);
            //    context.SaveChanges();
            //}

            //string outputFile = SINGLE_FILE_LOCATION + Guid.NewGuid().ToString() + ".jpg";
            //GetThumbnail("J:\\CloudCompare\\CloudCompare.Web\\Documents\\WhitePapers\\words.pdf");
            //var x = GhostscriptWrapper.GetPageThumb(TEST_FILE_LOCATION, outputFile, 3, 100, 100);

        }

    }
}
