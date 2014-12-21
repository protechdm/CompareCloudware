//<script language="javascript" type="text/javascript"></script>

//function ShowCompare(theForm) {
//    //if ($(theForm).valid()) {
//        setLoadingSearchResults(true);
//        //}
//}

//var testShowCompare = function (theForm) {
//    ShowCompare(theForm);
//}



















$(document).ready(function () {



    function setLoadingSearchResults(visibility) {

        if (visibility) {
            //alert("checked");
            $('.loading-search-results').css("visibility", "visible");
            $('.comparing-search-results').css("visibility", "visible");
        }
        else {
            //alert("not checked");
            $('.loading-search-results').css("visibility", "hidden");
            $('.comparing-search-results').css("visibility", "hidden");
        }
    }

    function setFilteringSearchResults(visibility) {
        if (visibility) {
            $('#filtering-search-results').modal('show');
        }
        else {
            $('#filtering-search-results').modal('hide');
        }
    }

    function setSortingSearchResults(visibility) {
        if (visibility) {
            $('#sorting-search-results').modal('show');
        }
        else {
            $('#sorting-search-results').modal('hide');
        }
    }

    function setPagingSearchResults(visibility) {

        if (visibility) {
            $('#paging-search-results').modal('show');
        }
        else {
            $('#paging-search-results').modal('hide');
        }
    }

    function setTakingToSelection(visibility) {

        if (visibility) {
            $('#taking-to-selection').modal('show');
        }
        else {
            $('#taking-to-selection').modal('hide');
        }
    }

    //CLICK ON SEARCHINPUTMODEL

    var searchInputContainerContext = $('.search-input-container');
    var searchInputContainerCategoryContext = $('.search-input-container-category');
    $('.show-search-splash', searchInputContainerContext).click(function (evt) {
        //setLoadingSearchResults(true);
        var theObject = this;
        var formContext = $(theObject).closest("form");


        if ($(formContext).valid()) {
            var terms = $(".terms", formContext);
            var isChecked = terms.prop("checked");
            //var users = $("#SearchInputModel_ChosenNumberOfUsers")[0];
            var users = $(".chosenNumberOfUsers",formContext)[0];
            var selectedIndex = users.selectedIndex;
            var text = users.options[selectedIndex].text;

            var canShowComparingScreen = true;
            if (!isChecked || text == 'User numbers') {
                canShowComparingScreen = false;
            }

            if (canShowComparingScreen) {
                setLoadingSearchResults(true);
            }
        }

    });

    $('.show-search-splash', searchInputContainerCategoryContext).click(function (evt) {
        //setLoadingSearchResults(true);
        var theObject = this;
        var formContext = $(theObject).closest("form");
        if ($(formContext).valid()) {
            var terms = $(".terms", formContext);
            var isChecked = terms.prop("checked");
            var users = $("#SearchInputModel_ChosenNumberOfUsers")[0];
            var selectedIndex = users.selectedIndex;
            var text = users.options[selectedIndex].text;

            var canShowComparingScreen = true;
            if (!isChecked || text == 'User numbers') {
                canShowComparingScreen = false;
            }

            if (canShowComparingScreen) {
                setLoadingSearchResults(true);
            }
        }

    });

    var tabbedSearchResultsContainerContext = $('.home-page-content');
    var tabbedSearchResultsContainerCategoryContext = $('.tabbed-search-results-container-category');
    //$('.tabbed-search-result-logo', tabbedSearchResultsContainerContext).click(function (evt) {
        $('.tabbed-search-result-logo img').click(function (evt) {
                setTakingToSelection(true);
    });



    //setResultsDisplay();
    //    collapseFilterGroups($('.header-categories'), 'true');
    //    collapseFilterGroups($('.header-users'), 'true');
    //    collapseFilterGroups($('.header-operating-systems'), 'true');
    //    collapseFilterGroups($('.header-devices'), 'true');
    //    collapseFilterGroups($('.header-browsers'), 'true');
    //    collapseFilterGroups($('.header-mobile-platforms'), 'true');
    //    collapseFilterGroups($('.header-features'), 'true');
    //    collapseFilterGroups($('.header-support-types'), 'true');
    //    collapseFilterGroups($('.header-support-days'), 'true');
    //    collapseFilterGroups($('.header-support-hours'), 'true');
    //    collapseFilterGroups($('.header-languages'), 'true');


    collapseAllFilterGroups();

    //RefreshActiveSupport();

    //    $(document).ready(function () {
    //setLoading(false);

    
    //setLoadingSearchResults(false);


    //$.validator.unobtrusive.parse('#dialog-input-review');
    //$.validator.unobtrusive.parse('form');

    function collapseAllFilterGroups() {
        collapseFilterGroups($('.header-categories'), $('.search-filter-categories'));
        collapseFilterGroups($('.header-users'), $('.search-filter-users'));
        collapseFilterGroups($('.header-operating-systems'), $('.search-filter-operating-systems'));
        collapseFilterGroups($('.header-devices'), $('.search-filter-devices'));
        collapseFilterGroups($('.header-browsers'), $('.search-filter-browsers'));
        collapseFilterGroups($('.header-mobile-platforms'), $('.search-filter-mobile-platforms'));
        collapseFilterGroups($('.header-features'), $('.search-filter-features'));
        collapseFilterGroups($('.header-support-types'), $('.search-filter-support-types'));
        collapseFilterGroups($('.header-support-days'), $('.search-filter-support-days'));
        collapseFilterGroups($('.header-support-hours'), $('.search-filter-support-hours'));
        collapseFilterGroups($('.header-languages'), $('.search-filter-languages'));
        collapseFilterGroups($('.header-timezones'), $('.search-filter-timezones'));
    }


    function setLoading(visibility) {

        if (visibility) {
            //alert("checked");
            $('.loading').css("visibility", "visible");
        }
        else {
            //alert("not checked");
            $('.loading').css("visibility", "hidden");
        }
    }


    function setResultsDisplay() {

        var theButton = $('#displayAsSummary');
        var checked = theButton.attr("checked");
        var theValue = theButton.attr("value");
        //if ($('#displayAsSummary').attr("checked") == "checked") {
        if (theValue != null) {
            if ($('#displayAsSummary').attr("value").toUpperCase() == "TRUE") {
                //alert("checked");
                $('#resultsFull').css("visibility", "hidden");
                $('#resultsSummary').css("visibility", "visible");
            }
            else {
                //alert("not checked");
                $('#resultsFull').css("visibility", "visible");
                $('#resultsSummary').css("visibility", "hidden");
            }
        }
    }
    //    });

    //$('div.search-filters-show:eq(0)> div').show();
    //function collapseFilterGroups(objectToCollapse, collapse) {
    function collapseFilterGroups(objectToCollapse, filtersToCollapse) {

        var isCollapsed = $(objectToCollapse).attr("value");
        //var test = $(objectToCollapse).children("#search-filter-group-header-label");
        //var test2 = $((objectToCollapse).children()[1]).children()[1];
        var test = $(filtersToCollapse).css("display");
        var collapse = ($(filtersToCollapse).css("display") != "block");
        //alert(test.attr("id"));
        if (collapse == true) {
            //$('div.search-filters-container-inner:eq(0)> div.search-filter-group-header').hide();
            $(objectToCollapse).next().hide();
        }
        else {
            //$('div.search-filters-container-inner:eq(0)> div.search-filter-group-header').show();
            $(objectToCollapse).next().show();
        }
    }

    function collapseObject(objectToCollapse) {
        var collapse = ($(objectToCollapse).css("display") == "block");
        if (collapse == true) {
            $(objectToCollapse).hide();
        }
        else {
            $(objectToCollapse).show();
        }
    }

    function setObjectVisibility(theObject, visibility) {

        if (visibility) {
            $(theObject).css("visibility", "visible");
        }
        else {
            $(theObject).css("visibility", "hidden");
        }
    }

    function toggleResults(obj) {
        //$('#displayAsSummary').click(function () {
        //alert("clicked");
        var classValue = $(obj).attr("class");
        //alert(classValue);
        var displayAsSummary = $('#displayAsSummary');
        //if (classValue.contains("site-button-full")) {
        if (classValue.indexOf("site-button-full") > -1) {
            //alert("clicked full");
            $('#resultsFull').css("visibility", "visible");
            $('#resultsSummary').css("visibility", "hidden");

            /*$('#resultsFull').css("display", "block");*/
            /*$('#resultsSummary').css("display", "none");*/

            $('.site-button-full').css("display", "none");
            $('.site-button-summary').css("display", "block");

            $('#displayAsSummary').removeAttr("checked");
            $('#displayAsSummary').attr("value", "false");
        }
        //if (classValue.contains("site-button-summary")) {
        if (classValue.indexOf("site-button-summary") > -1) {
                //alert("clicked summary");
            $('#resultsFull').css("visibility", "hidden");
            $('#resultsSummary').css("visibility", "visible");

            /*$('#resultsFull').css("display", "none");*/
            /*$('#resultsSummary').css("display", "block");*/

            $('.site-button-full').css("display", "block");
            $('.site-button-summary').css("display", "none");

            $('#displayAsSummary').attr("checked", "checked");
            $('#displayAsSummary').attr("value", "true");
        }
    }

    $('body').on('click', 'div.search-filters-container-inner:eq(0)> div.search-filter-group-header', function () {
        //$('div.search-filters-container-inner:eq(0)> div.search-filter-group-header').click(function () {

        $(this).next().slideToggle('fast');
        var test = $(this);
        var test2 = (test.children())[1];
        var test3 = $(test2).children()[1];
        //var test4 = $(test3).css("display");
        var test5 = $(test3).attr("value");
        if (test5.toUpperCase() == "TRUE") {
            $(test3).attr("value", false);
        }
        else {
            $(test3).attr("value", true);
        }
        //        var test5 = "";
        test5 = $(test3).attr("value");
        //alert(test5);
    });

    $('body').on('click', 'div.content-data-header', function () {
        //$('div.search-filters-container-inner:eq(0)> div.search-filter-group-header').click(function () {
        //alert("click");
        var t = $(this).parent().parent().next();
        $(t).slideToggle('fast');

        //$(t).next().slideToggle('fast');
    });

    $('.cloudware-explained-content-container').on('click', 'div.content-data-header', function () {
        var t = $('div', $(this).parent().parent().parent().parent().parent().parent().next())
        //$('div', $(this).parent().parent().parent().parent().next())
        var test = $(t).css("display");

        var selected = ($(t).css("display") != "block");
        if (selected == true)
        {
            $(this).addClass('content-data-header-selected');
            $(this).removeClass('content-data-header-not-selected');
        }
        else
        {
            $(this).removeClass('content-data-header-selected');
            $(this).addClass('content-data-header-not-selected');
        }
        $(t).slideToggle('fast');
    });

    collapseCloudwareExplained();

    function collapseCloudwareExplained() {
        collapseCloudwareExplainedAccordion($('.cloudware-explained-content-container .cloudware-explained-text'), $('.search-filter-categories'));
    }

    function collapseCloudwareExplainedAccordion(objectsToCollapse, filtersToCollapse)
    {
        $.each(objectsToCollapse



                , function (index, objectToCollapse) {
                    //var isCollapsed = $(objectToCollapse).attr("value");
                    var t = $('div', $(this).parent().parent().parent().parent().parent().parent().prev())
                    var test = $(t).css("display");
                    //var test = $(objectToCollapse).css("display");
                    var collapse = ($(objectToCollapse).css("display") == "block");
                    if (collapse == true) {
                        $(objectToCollapse).hide();
                        $(t).addClass('content-data-header-not-selected');
                        $(t).removeClass('.content-data-header-selected');
                    }
                    else {
                        $(objectToCollapse).show();
                        $(t).addClass('.content-data-header-selected');
                        $(t).removeClass('content-data-header-not-selected');
                    }
                });



    }

    $('body').on('click', '.site-button img[id^="MOREINFO"]', function () {
        var id = "#" + $(this).attr("id");
        id = id.replace("BUTTON", "DIV");
        //alert(id);
        //$('div.search-filters-container-inner:eq(0)> div.search-filter-group-header').click(function () {
        $(id).slideToggle('fast');
        //$(id).next().slideToggle('fast');
        $(id).css("display", "block");
    });

    $('body').on('click', '.site-button-full', function () {
        toggleResults(this);
    });

    $('body').on('click', '.site-button-summary', function () {
        toggleResults(this);
    });

    $('body').on('click', '.search-results-infobar-close', function () {
        $('#searchFiltersInfoBar').css("display", "none");
        $('#searchResultsInfoBar').css("display", "none");
    });

    $('body').on('click', '.terms-checked', function () {
        return HaveTermsBeenChecked(this);
    });

    $('body').on('click', '.users-chosen', function () {
        return HasUsersBeenChosen(this);
    });

    $('body').on('click', '.rating-review-terms-checked', function () {
        return HaveRatingReviewTermsBeenChecked();
    });

    function HaveTermsBeenChecked(theObject) {
        var formContext = $(theObject).closest("form");
        var terms = $(".terms", formContext);
        var isChecked = terms.prop("checked");
        if (!isChecked) {
            AlertToCheckTCs();
            return false;
        }
        else {
            return true;
        }
    }

    function HasUsersBeenChosen(theObject) {
        var formContext = $(theObject).closest("form");
        var users = $(".chosenNumberOfUsers", formContext)[0];
        var selectedIndex = users.selectedIndex;
        var text = users.options[selectedIndex].text;
        if (text == 'User numbers') {
            AlertToChooseUsers();
            return false;
        }
        else {
            return true;
        }
    }

    function HaveRatingReviewTermsBeenChecked() {
        //alert('terms');
        var terms = $(".rating-review-terms");
        var isChecked = terms.prop("checked");
        if (!isChecked) {
            AlertToCheckTCs();
            return false;
        }
        else {
            return true;
        }
    }

    function AlertToCheckTCs()
    {
        $('#dialog-message-tc').modal('show');
    }

    //var dlgTC = {
    //    DoSomething: function () {
    //        $("#dialog-message-tc").dialog("open");
    //    }
    //}

    //// Initialize my dialog
    //$("#dialog-message-tc").dialog({
    //    autoOpen: false,
    //    modal: true,
    //    resizable: false,
    //    closeText: null,
    //    buttons: {
    //        "OK": function (event, ui) {
    //            $(this).dialog("close");
    //        }
    //    }
    //});


    function AlertToChooseUsers()
    {
        $('#dialog-message-number-of-users').modal('show');
    }

    //var dlgNumberOfUsers = {
    //    DoSomething: function () {
    //        $("#dialog-message-number-of-users").dialog("open");
    //    }
    //}

    //// Initialize my dialog
    //$("#dialog-message-number-of-users").dialog({
    //    autoOpen: false,
    //    modal: true,
    //    resizable: false,
    //    closeText: null,
    //    buttons: {
    //        "OK": function (event, ui) {
    //            $(this).dialog("close");
    //        }
    //    }
    //});

    var filtersContext = $('search-filters-container-inner');

    //fires when a dropdown filter is changed
    $('body').on('change', 'select.filterParameter', function () {
        setFilteringSearchResults(true);
        var text = this.options[this.selectedIndex].text;
        var previouslyChosenCategoryID = $('#previouslyChosenCategoryID').attr("value");
        var chosenCategoryID = $('#chosenCategoryID option:selected').attr("value");
        var tagToRefresh;
        var refresh;
        refresh = true;
        var sortColumn = $('#currentSortOrder').val();
        var currentSortOrder = $('#currentSortOrder').val();
        tagToRefresh = ".search-page-container";
        //var serialize1 = $('#main form :input').serialize();
        var serialize1 = $('#main form .search-filters-container-inner input,#main form .search-filters-container-inner select').serialize();
        $.ajax({
            //url: '/Home/SearchFiltersPartial',
            url: '/SearchFiltersPartial',
            type: 'POST',
            //data: JSON.stringify("jsonData"),
            //data: $('#main form').serialize() + "&refreshResults=true",
            //data: "{ model: " + serialize1 + ", sortColumn: sortColumn, currentSortOrder: currentSortOrder, refreshResults: true }",
            //data: "{ model: " + serialize1 + ", refreshResults: " + refresh + " }",
            data: serialize1 + "&refreshResults=" + refresh + "&sortColumn=" + sortColumn + "&currentSortOrder=" + currentSortOrder,
            //dataType: 'json',
            //contentType: 'application/json',

            //The request was a success. Repopulate the div with new result set.
            success: function (data) {
                $(tagToRefresh).empty();
                //$(data).appendTo(tagToRefresh);
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                setResultsDisplay();
                //collapseFilterGroups("true");
                collapseAllFilterGroups();
                setFilteringSearchResults(false);
            },
            error: function (data) {
                setFilteringSearchResults(false);
                alert('Fail on dropdown');
            }
        });
        //}
    });

    //fires when a checkbox filter is changed
    $('body').on('change', 'input.filterParameter', function () {
        //var serialize1 = $('#main form').serialize();
        var serialize1 = $('#main form .search-filters-container-inner input,#main form .search-filters-container-inner select').serialize();
        debugger;
        setFilteringSearchResults(true);

        $.ajax({
            url: '/SearchResultsPartial',
            type: 'POST',
            data: serialize1,

            //The request was a success. Repopulate the div with new result set.
            success: function (data) {
                $(".search-results-container-outer").empty();
                $(jQuery.parseHTML(data)).appendTo(".search-results-container-outer");

                $("#searchResultsCount").text($("#searchResultsCountHidden").val());

                if ($('#displayAsSummary').attr("checked") == "checked") {
                    $('#resultsFull').css("visibility", "hidden");
                    $('#resultsSummary').css("visibility", "visible");
                }
                else {
                    $('#resultsFull').css("visibility", "visible");
                    $('#resultsSummary').css("visibility", "hidden");
                }
                setFilteringSearchResults(false);

            },
            error: function (data) {
                setFilteringSearchResults(false);
                alert('Fail on checkbox');
            }
        });
    });

    $('.filtering-search-results').on('shown.bs.modal', function (e) {
        //alert("in");
    });


    //fires when a sort column is clicked
    $('body').on('click', '.search-results-sort-column label', function () {
        setSortingSearchResults(true);
        var sortColumn = $(this).attr("id");
        var currentSortOrder = $('#currentSortOrder').val();
        //var serialize1 = $('#main form').serialize();
        var serialize1 = $('#main form .search-filters-container-inner input,#main form .search-filters-container-inner select').serialize();
        var refresh = false;
        $.ajax({
            url: '/SearchResultsPartial',
            type: 'POST',
            data: serialize1 + "&refreshResults=" + refresh + "&sortColumn=" + sortColumn + "&currentSortOrder=" + currentSortOrder,

            //The request was a success. Repopulate the div with new result set.
            success: function (data) {
                $(".search-results-container-outer").empty();
                //$(data).appendTo(".search-results-container-outer");
                $(jQuery.parseHTML(data)).appendTo(".search-results-container-outer");

                $("#searchResultsCount").text($("#searchResultsCountHidden").val());

                setResultsDisplay();

                setSortingSearchResults(false);

            },
            error: function (data) {
                setSortingSearchResults(false);
                alert('Fail on checkbox');
            }
        });
    });





    //fires when a search navigation button is clicked
    $('body').on('click', '.navigate-search-results', function () {

        setPagingSearchResults(true);
        var pageCount = $('#pageCount').val();
        var currentPageNumber = parseInt($('#currentPageNumber').val());
        var nextPageToRequest;
        var previousPageNumber = currentPageNumber - 1;
        var nextPageNumber = currentPageNumber + 1;
        //var serialize1 = $('#main form').serialize();
        var serialize1 = $('#main form .search-filters-container-inner input,#main form .search-filters-container-inner select').serialize();
        var thisObject = $(this).text();
        switch (thisObject) {
            case "<< First":
                nextPageToRequest = 1;
                break;
            case "< Previous":
                nextPageToRequest = previousPageNumber;
                break;
            case "Next >":
                nextPageToRequest = nextPageNumber;
                break;
            case "Last >>":
                nextPageToRequest = pageCount;
                break;
            default:
                nextPageToRequest = parseInt(thisObject);
                break;
        }

        if (nextPageToRequest != currentPageNumber && nextPageToRequest > 0 && nextPageToRequest <= pageCount) {
            $.ajax({
                url: '/GetNextSearchResultsPage',
                type: 'POST',
                data: serialize1 + "&page=" + nextPageToRequest,

                //The request was a success. Repopulate the div with new result set.
                success: function (data) {
                    $(".search-results-container-outer").empty();
                    //$(data).appendTo(".search-results-container-outer");
                    $(jQuery.parseHTML(data)).appendTo(".search-results-container-outer");
                    $("#searchResultsCount").text($("#searchResultsCountHidden").val());
                    //if ($('#displayAsSummary').attr("checked") == "checked") {
                    if ($('#displayAsSummary').attr("value").toUpperCase() == "TRUE") {
                        $('#resultsFull').css("visibility", "hidden");
                        $('#resultsSummary').css("visibility", "visible");
                    }
                    else {
                        $('#resultsFull').css("visibility", "visible");
                        $('#resultsSummary').css("visibility", "hidden");
                    }
                    setPagingSearchResults(false);
                    $('html, body').animate({ scrollTop: 0 }, 'fast');
                },
                error: function (data) {
                    setPagingSearchResults(false);
                    alert('Fail on search navigate');
                }
            });
        }
        else {
            setPagingSearchResults(false);
            //alert("Same page");
        }
    });





    //fires when a GLOBAL search navigation button is clicked
    $('body').on('click', '.navigate-global-search-results', function () {

        setPagingSearchResults(true);
        var pageCount = $('#pageCount').val();
        var currentPageNumber = parseInt($('#currentPageNumber').val());
        var nextPageToRequest;
        var previousPageNumber = currentPageNumber - 1;
        var nextPageNumber = currentPageNumber + 1;
        var serialize1 = $('#main form').serialize();
        var thisObject = $(this).text();
        switch (thisObject) {
            case "<< First":
                nextPageToRequest = 1;
                break;
            case "< Previous":
                nextPageToRequest = previousPageNumber;
                break;
            case "Next >":
                nextPageToRequest = nextPageNumber;
                break;
            case "Last >>":
                nextPageToRequest = pageCount;
                break;
            default:
                nextPageToRequest = parseInt(thisObject);
                break;
        }
        $.ajax({
            url: '/GetNextGlobalSearchResultsPage',
            type: 'POST',
            data: serialize1 + "&page=" + nextPageToRequest,

            //The request was a success. Repopulate the div with new result set.
            success: function (data) {
                $(".global-search-results-container-outer").empty();
                $(data).appendTo(".global-search-results-container-outer");
                //                $("#searchResultsCount").text($("#searchResultsCountHidden").val());
                //                if ($('#displayAsSummary').attr("checked") == "checked") {
                //                    $('#resultsFull').css("visibility", "hidden");
                //                    $('#resultsSummary').css("visibility", "visible");
                //                }
                //                else {
                //                    $('#resultsFull').css("visibility", "visible");
                //                    $('#resultsSummary').css("visibility", "hidden");
                //                }
                setPagingSearchResults(false);
                $('html, body').animate({ scrollTop: 0 }, 'fast');
            },
            error: function (data) {
                setPagingSearchResults(false);
                alert('Fail on search navigate');
            }
        });
    });




    //var $jQval = $.validator;
    //$jQval.unobtrusive.parse($(this));

    $.validator.unobtrusive.parse($('#main'));

    //fires when the application request (Free Trial/Buy Now) button is clicked
    //$('body').on('click', '#ApplicationRequestButton', function () {
    $('.ApplicationRequestButton','.free-trial-container-inner').off('click').on('click', function () {
        if (!HaveTermsBeenChecked(this)) {
            //AlertToCheckTCs();
            return false;
        }
        debugger;
        //var form = $(this).closest('form');
        var form = $('form .free-trial-details input');
        if ($(form).valid()) {
            var BuyNow = 1;
            var EMail = 2;
            var FreeTrial = 3;
            var freeTrialOffered = ($("#ContainerModel_ChosenCloudApplicationModel_FreeTrialBuyNow_FreeTrial").val().toUpperCase() == "TRUE");
            if (freeTrialOffered) {
                requestType = FreeTrial;
            }
            else {
                requestType = BuyNow;
            }

            //var serialize = $('#main form .free-trial-details :input').serialize();
            var serialize = $('#main form').serialize();
            var theButton = this;
            $.ajax({
                url: 'InsertApplicationRequest',
                type: 'POST',
                data: serialize,

                //The request was a success.
                success: function (data) {
                    dlgApplicationSubmit.DoSomething(theButton);
                },
                error: function (data) {
                    alert('Fail on application request');
                }
            });
        }
    });

    var windowToOpenOnTryBuy;
    var dlgApplicationSubmit = {
        DoSomething: function (theButton) {
            var BuyNow = 1;
            var EMail = 2;
            var FreeTrial = 3;
            var freeTrialOffered = ($("#ContainerModel_ChosenCloudApplicationModel_FreeTrialBuyNow_FreeTrial").val().toUpperCase() == "TRUE");

            var buttonPressed = $(theButton).attr("value");
            var requestType;

            if (buttonPressed != "SendToColleagueButton") {
                if (freeTrialOffered)
                {
                    requestType = FreeTrial;
                }
                else
                {
                    requestType = BuyNow;
                }
            }
            else
            {
                requestType = EMail;
            }

            switch (requestType) {
                case BuyNow:
                    //$("#ui-dialog-title-dialog-message-application-submission-complete").text('Request buy now complete');
                    windowToOpenOnTryBuy = $("#ContainerModel_ChosenCloudApplicationModel_BuyURL").val();

                    $('.social-share-container').off('hidden.bs.modal').on('hidden.bs.modal', function () {
                        //window.open(windowToOpenOnTryBuy, "_blank");
                        //OpenNewTab(windowToOpenOnTryBuy);
                    })

                    $('.social-share-container').modal('show');
                    break;
                case EMail:
                    //var test = $("#ui-dialog-title-dialog-message-application-submission-complete").text();
                    //$("#ui-dialog-title-dialog-message-application-submission-complete").text('Request Email complete');
                    windowToOpenOnTryBuy = null;


                    var serialize = $('#main form').serialize();
                    var theButton = this;
                    $.ajax({
                        url: 'InsertApplicationRequest',
                        type: 'POST',
                        data: serialize + '&sendToColleague=true',

                        //The request was a success.
                        success: function (data) {
                            dlgApplicationSubmit.DoSomething(theButton);
                        },
                        error: function (data) {
                            alert('Fail on application request');
                        }
                    });





                    break;
                case FreeTrial:
                    //$("#ui-dialog-title-dialog-message-application-submission-complete").text('Request free trial complete');
                    windowToOpenOnTryBuy = $("#ContainerModel_ChosenCloudApplicationModel_TryURL").val();

                    $('.social-share-container').off('hidden.bs.modal').on('hidden.bs.modal', function () {
                        //window.open(windowToOpenOnTryBuy, "_blank");
                        //OpenNewTab(windowToOpenOnTryBuy);
                    })

                    $('#social-share-container').modal('show');
                    break;
            }

            //$("#dialog-message-application-submission-complete").dialog("open");
        }
    }






    //fires when the EMail colleague button is clicked
    //$('body').on('click', '#ApplicationRequestButton', function () {
    $('.EMailColleagueButton', '.free-trial-container-inner').off('click').on('click', function () {
        //var form = $(this).closest('form');
        var form = $('form .send-to-colleague-container input:text,textarea');

        if ($(form).valid()) {
            var serialize = $('#main form').serialize();
            var theButton = this;
            $.ajax({
                url: 'InsertApplicationRequest',
                type: 'POST',
                data: serialize + '&sendToColleague=true',

                //The request was a success.
                success: function (data) {
                    $('.continue-button-link', $('#email-sent')).off('click').on('click', function () {
                        $('#email-sent').modal('hide')
                    });
                    $('#email-sent').modal('show')
                },
                error: function (data) {
                    alert('Fail on application request');
                }
            });
        }
    });





















    function OpenNewTab(href) {
        //alert("Attempting to open trybuy window");
        window.open(href, "_blank");
        document.getElementById('linkDynamic').href = href;
        //document.getElementById('linkDynamic').click();
    }

    $('.SkipSocialShareButton').off('click').on('click', function () {
        $('.social-share-container').modal('hide');
        //OpenNewTab('http://www.bbc.co.uk');
        OpenNewTab(windowToOpenOnTryBuy);
        //window.open('http://www.bbc.co.uk', "_blank");
    });

    // Initialize my dialog
    $("#dialog-message-application-submission-complete").dialog({
        autoOpen: false,
        modal: true,
        closeText: null,
        buttons: {
            "OK": function (event, ui) {
                $(this).dialog("close");
            }
        },
        close: function () {
            if (windowToOpenOnTryBuy != null) {
                var url = windowToOpenOnTryBuy;
                window.open(url, "_blank");
            }
        }
    });










    //fires when the email page button is clicked
    $('.EMailRequestButton','.free-trial-container-inner').off('click').on('click', function () {

        var form = $(this).closest('form');
        if ($(form).valid()) {

            var serialize = $('#main form').serialize();
            var theButton = this;

            setLoading(true);

            $.ajax({
                url: 'EmailApplicationRequest',
                type: 'POST',
                data: serialize,

                //The request was a success.
                success: function (data) {
                    setLoading(false);
                    dlgApplicationEmail.DoSomething(theButton);
                },
                error: function (data) {
                    setLoading(false);
                    alert('Fail on application email');
                }
            });
        }
        //else {
        //    $(".input-validation-error:first").focus();
        //    $(".request-types option[value='3']").attr("selected", "selected");

        //}
    });


    var dlgApplicationEmail = {
        DoSomething: function (theButton) {
            $("#dialog-message-application-email-complete").dialog("open");
        }
    }

    // Initialize my dialog
    $("#dialog-message-application-email-complete").dialog({
        autoOpen: false,
        modal: true,
        closeText: null,
        buttons: {
            "OK": function (event, ui) {
                $(this).dialog("close");
            }
        },
    });













    //fires when the create review button is clicked
    $('body').on('click', '#CreateUserReviewButton', function () {
        dlgInputReview.DoSomething();
    });


    var dlgInputReview = {
        DoSomething: function () {
            $("#dialog-input-review").modal("show");
        }
    }

    // Initialize my dialog
    $("#dialog-input-review").dialog({
        autoOpen: false,
        modal: true,
        width: 440,
        closeText: null,
        resizable: false,
        open: function (event, ui) {
            // Enable validation for unobtrusive stuffs
            //$(this).load(options.url, function () {
            //var theform = $('#myform'); ??
            //$(this).appendTo($('#myform'));
            //$(this).parent().appendTo($('#myform'));
            //var $jQval = $.validator; ??
            //$jQval.unobtrusive.parse($(this)); ??
            var updateTargetId = "";
            var updateUrl = "";
            //wireUpForm(this, updateTargetId, updateUrl); ??
            //            //});

        }
    });




    //        autoOpen: false,
    //        modal: true,
    //        resizable: false,
    //        closeText: null,
    //        buttons: {
    //            //"???": function () {
    //            //$(this).dialog("close");
    //            //window.location.href = "SearchPage";
    //            //$.post("BackToSearchResults");
    //            //},
    //            //"Cancel": function() { $(this).dialog("close"); }
    //            "OK": function (event, ui) {
    //                $(this).dialog("close");
    //                //window.location.href = "BackToSearchResults";
    //            }
    //        }








    //fires when the submit rating button is clicked
    $('body').on('click', '#applicationRatingButton', function () {


        //if ($('#dialog-input-review form').valid()) {
        //if ($('#dialog-input-review').valid()) {
        //if ($('#dialog-input-review').validate().form()) {
        //if ($('#review').validate().form()) {
        //var x = $('#dialog-input-review');
        //var a = $('#myform');
        //var y = a.validate();
        //var z = y.form();
        //var z = a.valid();
        //var a = $('#CloudApplicationRatingReviewerName');
        //        if (x.valid()) {
        //            var e = 1;
        //        }

        //var $jQval = $.validator;
        //$jQval.unobtrusive.parse($('#dialog-input-review'));
        //var a = $('#xmyform').validate().form();
        //var b = $('#CloudApplicationRatingReviewerTitle').validate().valid();
        //var c = $.validator.unobtrusive.parse($('#xmyform'));
        if (!HaveRatingReviewTermsBeenChecked()) {
            //AlertToCheckTCs();
            return false;
        }

        if ($('#xmyform').valid()) {
            var serialize1 = $('#xmyform').serialize();

            setLoading(true);
            $.ajax({
                url: '/UserReview',
                type: 'POST',
                data: serialize1,

                //The request was a success.
                success: function (data) {
                    setLoading(false);
                    $("#dialog-input-review").dialog('close');
                    dlgRatingReviewCreated.DoSomething();
                },
                error: function (data) {
                    setLoading(false);
                    alert('Fail on create review');
                }
            });
        }
    });

    $(function () {
        $('#myform').submit(function () {
            if ($(this).valid()) {
                //alert('the form is valid');
            }
        });
    });

    function wireUpForm(dialog, updateTargetId, updateUrl) {
        $('#myform', dialog).submit(function () {

            // Do not submit if the form
            // does not pass client side validation
            if (!$(this).valid())
                return false;

            //	        // Client side validation passed, submit the form
            //	        // using the jQuery.ajax form
            //	        $.ajax({
            //	            url: this.action,
            //	            type: this.method,
            //	            data: $(this).serialize(),
            //	            success: function (result) {
            //	                // Check whether the post was successful
            //	                if (result.success) {                   
            //	                    // Close the dialog
            //	                    $(dialog).dialog('close');
            //	 
            //	                    // Reload the updated data in the target div
            //	                    $(updateTargetId).load(updateUrl);
            //	                } else {
            //	                    // Reload the dialog to show model errors                   
            //	                    $(dialog).html(result);
            //	 
            //	                    // Enable client side validation
            //	                    $.validator.unobtrusive.parse(dialog);
            //	 
            //	                    // Setup the ajax submit logic
            //	                    wireUpForm(dialog, updateTargetId, updateUrl);
            //	                }
            //	            }
            //	        });
            return false;
        });
    }
    var dlgRatingReviewCreated = {
        DoSomething: function () {
            $("#dialog-message-rating-review-complete").dialog("open");
        }
    }

    // Initialize my dialog
    $("#dialog-message-rating-review-complete").dialog({
        autoOpen: false,
        modal: true,
        closeText: null,
        buttons: {
            //"???": function () {
            //$(this).dialog("close");
            //window.location.href = "SearchPage";
            //$.post("BackToSearchResults");
            //},
            //"Cancel": function() { $(this).dialog("close"); }
            "OK": function (event, ui) {
                $(this).dialog("close");
                //window.location.href = "BackToSearchResults";
            }
            //close: function (event, ui) { window.location.href = "SearchPage"; 
        }
    });










    //    $("#xSearchInput").autocomplete({
    //        source: function (request, response) {
    //            $.ajax({
    //                url: "AutoComplete",
    //                dataType: "json",
    //                data: {
    //                    searchText: request.term
    //                },
    //                success: function (data) {
    //                    var locations = data;

    //                    response($.map(data, function (item) {
    //                        return {
    //                            category: item.Category,
    //                            tagID: item.TagID,
    //                            tagName: item.TagName,
    //                            tagType: item.TagType,
    //                            serviceName: item.CloudApplicationModel.ServiceName,
    //                            vendorName: item.CloudApplicationModel.Vendor.VendorName
    //                        }
    //                    }));

    //                    $("#SearchInput").catcomplete();
    //                    $("#SearchInput").catcomplete("source", data);

    //                },
    //                error: function (data) {
    //                    alert('Fail on autocomplete search');
    //                }
    //            });
    //        },
    //        minLength: 3,
    //        select: function (event, ui) {
    //            //log(ui.location ? "Selected: " + ui.location : "Nothing selected, input was " + this.value);
    //        },
    //        open: function () {
    //            $(this).removeClass("ui-corner-all").addClass("ui-corner-top");
    //        },
    //        close: function () {
    //            $(this).removeClass("ui-corner-top").addClass("ui-corner-all");
    //        },
    //        appendTo: ".searchTagsResults"
    //    })


    //            .data("autocomplete")._renderItem = function (ul, item) {
    //                //return $("<li></li>")
    //                return $("<li data-address=" + JSON.stringify(item) + "></li>")
    //                .data("item.autocomplete", item)
    //                //.append("<a autocomplete='true'>" + item.location + "<br>" + item.locationCode + "<br>" + item.distanceFromWork + "<br>" + item.address1 + "</a>")
    //                //.append("<a style='width:340px' autocomplete='true' class='ui-corner-all'><span class='lsLocationType'></span><span class='lsOpenOrClosed'></span>" + item.tagName + "</a>")
    //                .append("<a style='width:340px' autocomplete='true' class='ui-corner-all'>" + "TAGTYPE:" + item.tagType.TagTypeName + " - " + "TAGNAME:" + item.tagName + " - " + "SERVICENAME:" + item.serviceName + " - " + "CATEGORY:" + item.category.CategoryName + " - " + "VENDOR:" + item.vendorName + "</a>")
    //                .appendTo(ul);
    //            };

    ////    $.widget("custom.catcomplete", $.ui.autocomplete, {
    ////        _renderMenu: function (ul, items) {
    ////            var that = this,
    ////                currentCategory = "";
    ////            $.each(items, function (index, item) {
    ////                if (item.category != currentCategory) {
    ////                    ul.append("<li class='ui-autocomplete-category'>" + item.tagType.TagTypeName + "</li>");
    ////                    currentCategory = item.tagType.TagTypeName;
    ////                }
    ////                that._renderItemData(ul, item);
    ////            });
    ////        }
    ////    });

    //    //xxx._renderMenu = function (ul, items) {
    //    //            .data("autocomplete")._renderMenu = function (ul, items) {
    //    //                var that = this,
    //    //                currentCategory = "";
    //    //                $.each(items, function (index, item) {
    //    //                    if (item.tagType.TagTypeName != currentCategory) {
    //    //                        ul.append("<li class='ui-autocomplete-category'>" + item.tagType.TagTypeName + "</li>");
    //    //                        currentCategory = item.tagType.TagTypeName;
    //    //                    }
    //    //                    //ul.append("<li class='ui-autocomplete-category'>" + "<a style='width:340px' autocomplete='true' class='ui-corner-all'>" + "TAGTYPE:" + item.tagType.TagTypeName + " - " + "TAGNAME:" + item.tagName + " - " + "SERVICENAME:" + item.serviceName + " - " + "CATEGORY:" + item.category.CategoryName + " - " + "VENDOR:" + item.vendorName + "</a>" + "</li>")
    //    //                    ul.append("<li class='ui-menu-item'>" + "<a style='width:340px' autocomplete='true' class='ui-corner-all'>" + "TAGTYPE:" + item.tagType.TagTypeName + " - " + "TAGNAME:" + item.tagName + " - " + "SERVICENAME:" + item.serviceName + " - " + "CATEGORY:" + item.category.CategoryName + " - " + "VENDOR:" + item.vendorName + "</a>" + "</li>")
    //    //                });
    //    //            }


    //fires when the create review button is clicked
    $('body').on('click', '.viewReviewDialog', function () {
        //var thisObject = $(this).text();
        //var url = $(this).attr("data");
        var thisObject = $(this);
        var URLObject = $(thisObject).next();
        var URLObjectText = $(URLObject).text();

        var URLDocumentExtensionObject = $(URLObject).next();
        var URLDocumentExtensionObjectText = $(URLDocumentExtensionObject).text();

        var theReviewFrame = $('#theReview');
        $(theReviewFrame).attr("src", URLObjectText);

        if (URLDocumentExtensionObjectText == "PDF") {
            dlgViewReview.DoSomething();
        }
        else if (URLDocumentExtensionObjectText == "HTML") {
            dlgViewReview.DoSomething();
        }
        else {
            dlgProductReviewDownloaded.DoSomething();
        }
        //var url = "http://www.samplepdf.com/sample.pdf";
        //url = "http://www.stluciadance.com/prospectus_file/sample.pdf";
        //url = "http://localhost:3785/home.mvc/homepage";

        //        UrlExists(url, function (status) {
        //            if (status === 200) {
        //                // file was found
        //                $.ajax({
        //                    url: 'LogBrokenLink',
        //                    type: 'POST',
        //                    data: "link=" + url,

        //                    //The request was a success. Repopulate the div with new result set.
        //                    success: function (data) {
        //                        alert('Success on logging broken link 200 for URL ' + url);
        //                    },
        //                    error: function (data) {
        //                        alert('Fail on logging broken link 200 for URL ' + url);
        //                    }
        //                });
        //            }
        //            else if (status === 404) {
        //                $.ajax({
        //                    url: 'LogBrokenLink',
        //                    type: 'POST',
        //                    data: "link=" + url,

        //                    //The request was a success. Repopulate the div with new result set.
        //                    success: function (data) {
        //                        alert('Success on logging broken link 404 for URL ' + url);
        //                    },
        //                    error: function (data) {
        //                        alert('Fail on logging broken link 404 for URL ' + url);
        //                    }
        //                });
        //            }
        //            else if (status === -1) {
        //                $.ajax({
        //                    url: 'LogBrokenLink',
        //                    type: 'POST',
        //                    data: "link=" + url,

        //                    //The request was a success. Repopulate the div with new result set.
        //                    success: function (data) {
        //                        alert('Success on logging broken link -1 for URL ' + url);
        //                    },
        //                    error: function (data) {
        //                        alert('Fail on logging broken link -1 for URL ' + url);
        //                    }
        //                });
        //            }
        //            else {
        //                //                $.ajax({
        //                //                    url: 'Log',
        //                //                    type: 'POST',
        //                //                    data: "link=" + url,

        //                //                    //The request was a success. Repopulate the div with new result set.
        //                //                    success: function (data) {
        //                //                        alert('Success on logging broken link');
        //                //                    },
        //                //                    error: function (data) {
        //                //                        alert('Fail on logging broken link');
        //                //                    }
        //                //                });

        //                dlgViewReview.DoSomething();

        //            }
        //        });

        //        if (UrlExists(url)) {
        //            dlgViewReview.DoSomething();
        //        }
    });


    var dlgViewReview = {
        DoSomething: function () {
            $("#dialog-view-review").dialog("open");
        }
    }

    // Initialize my dialog
    $("#dialog-view-review").dialog({
        autoOpen: false,
        modal: true,
        width: 600,
        height: 800,
        resizable: true,
        draggable: true,
        closeText: null,
        buttons: {
            //"???": function () {
            //$(this).dialog("close");
            //window.location.href = "SearchPage";
            //$.post("BackToSearchResults");
            //},
            //"Cancel": function() { $(this).dialog("close"); }
            "Close": function (event, ui) {
                $(this).dialog("close");
                //window.location.href = "BackToSearchResults";
            }
            //close: function (event, ui) { window.location.href = "SearchPage"; 
        },
        open: function (event, ui) {
            // Enable validation for unobtrusive stuffs
            //$(this).load(options.url, function () {
            var theform = $('#myform');
            //$(this).appendTo($('#myform'));
            //$(this).parent().appendTo($('#myform'));
            var $jQval = $.validator;
            $jQval.unobtrusive.parse($(this));
            var updateTargetId = "";
            var updateUrl = "";
            wireUpForm(this, updateTargetId, updateUrl);
            //});

        }
    });

    var dlgProductReviewDownloaded = {
        DoSomething: function () {
            $("#dialog-message-product-review-download-complete").dialog("open");
        }
    }

    // Initialize my dialog
    $("#dialog-message-product-review-download-complete").dialog({
        autoOpen: false,
        modal: true,
        closeText: null,
        buttons: {
            //"???": function () {
            //$(this).dialog("close");
            //window.location.href = "SearchPage";
            //$.post("BackToSearchResults");
            //},
            //"Cancel": function() { $(this).dialog("close"); }
            "OK": function (event, ui) {
                $(this).dialog("close");
                //window.location.href = "BackToSearchResults";
            }
            //close: function (event, ui) { window.location.href = "SearchPage"; 
        }
    });

    //    function UrlExists(url) {
    //        var http = new XMLHttpRequest();
    //        http.open('HEAD', url, false);
    //        http.send();
    //        return http.status != 404;
    //    }

    function UrlExists(url, cb) {
        jQuery.ajax({
            url: url,
            dataType: 'text/html',
            type: 'GET',
            complete: function (xhr) {
                alert('Completed accessing link');
                if (typeof cb === 'function')
                    cb.apply(this, [xhr.status]);
            },
            success: function (data) {
                alert('Success on accessing link');
                if (typeof cb === 'function')
                    cb.apply(this, [0]);
            },
            error: function (data) {
                alert('Fail on accessing link');
                if (typeof cb === 'function')
                    cb.apply(this, [-1]);
            }
        });
    }


    //BETA TAB
    $('.header-pinned-beta-container').on('click', function () {
        $('#betaSplash').modal('show');
        //        $.ajax({
        //            url: 'BetaSplashShown',
        //            type: 'POST',

        //            //The request was a success.
        //            success: function (data) {
        //                $('#betaSplash').modal('hide');
        //            },
        //            error: function (data) {
        //                $('#betaSplash').modal('hide');
        //            }
        //        });
    });


    $('.send-to-colleague-header-button').off('click').on('click', function () {
        collapseObject($('.send-to-colleague-input-container'));
    });

    $('.free-trial-edit-details').off('click').on('click', function () {
        collapseObject($('.free-trial-details'));
        collapseObject($('.free-trial-summary'));
    });

    $('.partner-programme-button').off('click').on('click', function () {
        var formContext = $(this).closest('form');

        formContext.removeData('validator');
        formContext.removeData('unobtrusiveValidation');
        $.validator.unobtrusive.parse($(formContext));

        if ($(formContext).valid()) {

            var serialize = $(formContext).serializeArray();

            $(serialize).each(function (index) {
                //debugger;
                this.name = this.name.substring(this.name.lastIndexOf('.') + 1)
                console.log(index + ": " + $(this).text());
            });

            $.ajax({
                url: '/PartnerProgramme',
                type: 'POST',
                data: serialize,

                //The request was a success.
                success: function (data) {
                    var existingData = $('.recaptcha-object-data', formContext);
                    var newData = $('.recaptcha-object-data', data);

                    var tagToRefresh = existingData;
                    //$(tagToRefresh).empty();
                    //$(jQuery.parseHTML(newData)).appendTo(tagToRefresh);
                    var recaptchaError = $('.field-validation-error', newData)

                    var oldRecaptchaError = $('.field-validation-error', existingData)
                    $(oldRecaptchaError).remove();

                    $(recaptchaError).appendTo(tagToRefresh);


                    Recaptcha.reload();


                    var showVideo = $('.show-partner-programme-video',data).val().toUpperCase();
                    if (showVideo == 'TRUE')
                    {
                        var videoContainer = $('.videoContainer', data);
                        existingData = $('.video-object-data', formContext);
                        existingData.empty();
                        $(videoContainer).appendTo(existingData);
                    }

                    var isRegistered = $('.is-registered',data).val().toUpperCase();
                    if (isRegistered == 'TRUE') {

                        $('.continue-button-link', $('#thanks-for-registering')).off('click').on('click', function () {
                            $('#thanks-for-registering').modal('hide')
                        });
                        var registeredForename = $(".register-now-forename",data).val();
                        var thanksForRegisteringName = $(".thanks-for-registering-name");
                        $(thanksForRegisteringName).html(registeredForename);
                        $('#thanks-for-registering').modal('show')
                    }
                },
                error: function (data) {
                    debugger;
                    var x = "";
                }
            });
        }
        else {
            //alert('not valid');
            $(formContext).find('div.control-group').each(function () {
                if ($(this).find('.field-validation-error').length > 0) {
                    $(this).addClass('error');
                }
            });
        }
    });




























    //    //VENDOR INTERFACE

    //    //fires when the upload video button is clicked
    //    $('body').on('click', '#uploadVideoButton', function () {
    //        dlgUploadVideo.DoSomething();
    //    });


    //    var dlgUploadVideo = {
    //        DoSomething: function () {
    //            $("#dialog-upload-video").dialog("open");
    //        }
    //    }

    //    // Initialize my dialog
    //    $("#dialog-upload-video").dialog({
    //        autoOpen: false,
    //        modal: true,
    //        width: 950,
    //        resizable: false,
    //        closeText: null,
    //        open: function (event, ui) {
    //            // Enable validation for unobtrusive stuffs
    //            //$(this).load(options.url, function () {
    //            //var theform = $('#uploadImageForm');
    //            var theform = $('#registerApplicationForm');
    //            //$(this).appendTo($('#myform'));
    //            //$(this).parent().appendTo($('#registerApplicationForm'));
    //            //$(this).parent.empty();
    //            var $jQval = $.validator;
    //            $jQval.unobtrusive.parse($(this));
    //            var updateTargetId = "";
    //            var updateUrl = "";
    //            wireUpForm(this, updateTargetId, updateUrl);
    //            //});

    //        }
    //    });


    //    //fires when the upload logo button is clicked
    //    $('body').on('click', '#uploadVideoAJAXButton', function () {

    //        //alert("IN");
    //        //if ($('#dialog-upload-image').valid()) {
    //        //var test = $('#dialog-upload-image');
    //        //var serialize1 = $('#dialog-upload-image').serialize();
    //        //var serialize1 = $('.ui-dialog').serialize();
    //        //var serialize1 = $('#registerApplicationForm').serialize();
    //        var serialize1 = $('#uploadVideoForm').serialize();
    //        //var fileName = $('.file').val();
    //        //data: serialize1 + "&refreshResults=" + refresh + "&sortColumn=" + sortColumn + "&currentSortOrder=" + currentSortOrder,
    //        //setLoading(true);

    //        $.ajax({
    //            url: 'UploadVideo',
    //            type: 'POST',
    //            data: serialize1,
    //            //contentType:attr("enctype", "multipart/form-data"),
    //            //contentType: 'multipart/form-data',
    //            //The request was a success.
    //            success: function (data) {
    //                //setLoading(false);


    //                $("#dialog-upload-video").dialog('close');
    //                //dlgRatingReviewCreated.DoSomething();

    //                $(".application-video").empty();
    //                $(data).appendTo($(".application-video"));

    //            },
    //            error: function (data) {
    //                setLoading(false);
    //                alert('Fail on uploading video');
    //            }
    //        });
    //        //}
    //    });















    //    //var videoUploadContext = $('#dialog-upload-video');
    //    var videoUploadContext = $('#uploadVideoForm');
    //    //initSelect(context);
    //    //var invalidURL = $('#invalidURL');
    //    //var isBrokenLink = $('#IsBrokenLink');
    //    //What happens if the File changes?
    //    $('#playVideoButton', videoUploadContext).click(function (evt) {
    //        var serialize = videoUploadContext.serialize();
    //        var url = this.value;
    //        var tagToRefresh = $('#video-cut', videoUploadContext);
    //        $.ajax({
    //            url: 'PlayVideo',
    //            type: 'POST',
    //            data: serialize,

    //            //The request was a success.
    //            success: function (data) {
    //                //setLoading(false);
    //                $(tagToRefresh).empty();
    //                $(data).appendTo(tagToRefresh);

    //                //                    if (data.toUpperCase() == "TRUE") {
    //                //                        preview.attr('src', "http://" + url);
    //                //                        preview.css("visibility", "visible");
    //                //                        invalidURL.css("visibility", "hidden");
    //                //                        isBrokenLink.attr('value', false);
    //                //                    }
    //                //                    else {
    //                //                        preview.css("visibility", "hidden");
    //                //                        //preview.css("display", "none");
    //                //                        //$('#uploadLogoFULLButton').attr('disabled', false);
    //                //                        preview.attr('src', "");
    //                //                        invalidURL.css("visibility", "visible");
    //                //                        isBrokenLink.attr('value', true);
    //                //                    }
    //            },
    //            error: function (data) {
    //                //setLoading(false);
    //                alert('Fail on playing video');
    //            }
    //        });

    //    });



    //    //NOT USED!!!!
    //    //What happens if the File Format changes?
    //    //$('#CloudApplicationVideoExtensions_ChosenValue', videoUploadContext).click(function (evt) {
    //    $('.xradCustomRadioButtonList', videoUploadContext).click(function (evt) {


    //        var serialize = videoUploadContext.serialize();
    //        var url = this.value;
    //        var tagToRefresh = $('#video-cut', videoUploadContext);
    //        $.ajax({
    //            url: 'RefreshVideo',
    //            type: 'POST',
    //            data: serialize,

    //            //The request was a success.
    //            success: function (data) {
    //                //setLoading(false);
    //                $(tagToRefresh).empty();
    //                $(data).appendTo(tagToRefresh);

    //                //                    if (data.toUpperCase() == "TRUE") {
    //                //                        preview.attr('src', "http://" + url);
    //                //                        preview.css("visibility", "visible");
    //                //                        invalidURL.css("visibility", "hidden");
    //                //                        isBrokenLink.attr('value', false);
    //                //                    }
    //                //                    else {
    //                //                        preview.css("visibility", "hidden");
    //                //                        //preview.css("display", "none");
    //                //                        //$('#uploadLogoFULLButton').attr('disabled', false);
    //                //                        preview.attr('src', "");
    //                //                        invalidURL.css("visibility", "visible");
    //                //                        isBrokenLink.attr('value', true);
    //                //                    }
    //            },
    //            error: function (data) {
    //                //setLoading(false);
    //                alert('Fail on uploading video');
    //            }
    //        });

    //    });























    //    /////////////////////////////////////////////////////////////////////////////////////////////////////////

    //    //USER REVIEWS CONTAINER

    //    var userReviewsContainerContext = $('.user-reviews-container');
    //    //var userReviewsContainerContext = $('.register-application');

    //    //$('#newUserReviewButton', userReviewsContainerContext).click(function () {
    //    $(document).on('click', '#newUserReviewButton', function () {
    //        //$('body').on('click', '#newUserReviewButton', function () {
    //        //        $('#CloudApplicationReviewHeadline').attr('value', '');
    //        //        $('#CloudApplicationReviewPublisherName').attr('value', '');
    //        //        $('#CloudApplicationReviewText').attr('value', '');
    //        //        $('#CloudApplicationReviewURL').attr('value', '');
    //        RefreshUploadUserReview();
    //        dlgUploadUserReview.DoSomething();
    //    });

    //    //$('.user-reviews-container tr', userReviewsContainerContext).click(function () {
    //    $(document).on('click', '.user-reviews-container td:has(label)', function () {
    //        //$('body').on('click', '.user-reviews-container tr', function () {
    //        //$('.product-reviews-container tr').click(function () {
    //        //var href = $(this).find("a").attr("href");
    //        var href = $(this).parent().find("a");
    //        if (href) {
    //            //var href2 = $(this).find("a");
    //            var rowID = href.attr("id");
    //            //alert(rowID);




    //            var tagToRefresh = "#dialog-upload-user-review";

    //            $.ajax({
    //                url: 'FindUserReview',
    //                type: 'POST',
    //                data: "rowID=" + rowID,
    //                //contentType:attr("enctype", "multipart/form-data"),

    //                //The request was a success.
    //                success: function (data) {
    //                    //                    setLoading(false);
    //                    //                    $("#dialog-upload-product-review").dialog('close');
    //                    $(tagToRefresh).empty();
    //                    $(data).appendTo(tagToRefresh);
    //                },
    //                error: function (data) {
    //                    //                    setLoading(false);
    //                    alert('Fail on uploading user review');
    //                }
    //            });
    //            dlgUploadUserReview.DoSomething();
    //            //window.location = href;
    //        }
    //    });

    //    $(document).on('click', '.cloudApplicationUserReviewDelete', function () {
    //        var rowID = $(this).attr("id");


    //        var tagToRefresh = ".user-reviews-container";

    //        $.ajax({
    //            url: 'DeleteUserReview',
    //            type: 'POST',
    //            data: "rowID=" + rowID,
    //            //contentType:attr("enctype", "multipart/form-data"),

    //            //The request was a success.
    //            success: function (data) {
    //                //                    setLoading(false);
    //                //                    $("#dialog-upload-product-review").dialog('close');
    //                $(tagToRefresh).empty();
    //                $(data).appendTo(tagToRefresh);
    //            },
    //            error: function (data) {
    //                //                    setLoading(false);
    //                alert('Fail on deleting user review');
    //            }
    //        });
    //        return false;
    //    });

    //    var dlgUploadUserReview = {
    //        DoSomething: function () {
    //            $("#dialog-upload-user-review").dialog("open");
    //        }
    //    }



    //    // Initialize my dialog
    //    $("#dialog-upload-user-review").dialog({
    //        autoOpen: false,
    //        modal: true,
    //        width: 750,
    //        resizable: false,
    //        closeText: null,
    //        open: function (event, ui) {
    //            // Enable validation for unobtrusive stuffs
    //            //$(this).load(options.url, function () {
    //            //var theform = $('#uploadImageForm');
    //            //var theform = $('#registerApplicationForm');
    //            //$(this).appendTo($('#myform'));
    //            //$(this).parent().appendTo($('#registerApplicationForm'));
    //            //$(this).parent.empty();
    //            //var $jQval = $.validator;
    //            //$jQval.unobtrusive.parse($(this));
    //            //var updateTargetId = "";
    //            //var updateUrl = "";
    //            //wireUpForm(this, updateTargetId, updateUrl);
    //            //});

    //        }
    //    });


    //    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //    //USER REVIEWS
    //    var userReviewContext = $('#dialog-upload-user-review');
    //    //var userReviewContext = $('.register-application');

    //    //UPLOAD USER REVIEW CLICK
    //    //$('body').on('click', '#uploadUserReviewAJAXButton', function () {
    //    //$('#uploadUserReviewAJAXButton', userReviewContext).click(function () {
    //    $(document).on('click', '#uploadUserReviewAJAXButton', function () {


    //        //if ($('#dialog-upload-image').valid()) {
    //        //var test = $('#dialog-upload-product-review');
    //        //var serialize1 = $('#dialog-upload-product-review').serialize();
    //        //var serialize1 = $('.ui-dialog').serialize();
    //        var serialize2 = $('#uploadUserReviewForm').serialize();
    //        var tagToRefresh = ".user-reviews-container";
    //        //var fileName = $('.file').val();
    //        //data: serialize1 + "&refreshResults=" + refresh + "&sortColumn=" + sortColumn + "&currentSortOrder=" + currentSortOrder,
    //        //setLoading(true);


    //        //var a = $('#uploadUserReviewForm').validate().form();
    //        //var b = $('#CloudApplicationRatingReviewerTitle').validate().valid();
    //        //var c = $.validator.unobtrusive.parse($('#uploadUserReviewForm'));
    //        if ($('#uploadUserReviewForm').valid()) {

    //            $.ajax({
    //                url: 'UploadUserReview',
    //                type: 'POST',
    //                data: serialize2,
    //                //contentType:attr("enctype", "multipart/form-data"),

    //                //The request was a success.
    //                success: function (data) {
    //                    //setLoading(false);
    //                    $("#dialog-upload-user-review").dialog('close');
    //                    //dlgRatingReviewCreated.DoSomething();
    //                    $(tagToRefresh).empty();
    //                    $(data).appendTo(tagToRefresh);
    //                    //RefreshUploadUserReview();
    //                },
    //                error: function (data) {
    //                    //setLoading(false);
    //                    alert('Fail on uploading user review');
    //                }
    //            });
    //            userReviewsContainerContext = $('.user-reviews-container');

    //        }
    //    });

    //    function RefreshUploadUserReview() {
    //        var tagToRefresh = "#dialog-upload-user-review";
    //        $.ajax({
    //            url: 'RefreshUploadUserReview',
    //            type: 'POST',
    //            //data: serialize2,
    //            //contentType:attr("enctype", "multipart/form-data"),

    //            //The request was a success.
    //            success: function (data) {
    //                //setLoading(false);
    //                $(tagToRefresh).empty();
    //                $(data).appendTo(tagToRefresh);
    //            },
    //            error: function (data) {
    //                //setLoading(false);
    //                alert('Fail on uploading user review');
    //            }
    //        });
    //    }










    //    //////////////////////////////////////////////////////////////////////////////////////////////////////

    //    //DOCUMENTS CONTAINER


    //    var documentsContainerContext = $('#dialog-upload-document');

    //    //NEW DOCUMENT BUTTON CLICK
    //    //$('#newDocumentButton', documentsContainerContext).click(function () {
    //    $(document).on('click', '#newDocumentButton', function () {
    //        //$('body').on('click', '#newDocumentButton', function () {
    //        RefreshUploadDocument();
    //        dlgUploadDocument.DoSomething();
    //    });

    //    //$('body').on('click', '.documents-container tr', function () {
    //    $(document).on('click', '.documents-container td:has(label)', function () {
    //        //$('.product-reviews-container tr').click(function () {
    //        var tagToRefresh = "#dialog-upload-document";

    //        var href = $(this).parent().find("a");
    //        if (href) {
    //            var rowID = href.attr("id");

    //            $.ajax({
    //                url: 'FindDocument',
    //                type: 'POST',
    //                data: "rowID=" + rowID,
    //                //contentType:attr("enctype", "multipart/form-data"),

    //                //The request was a success.
    //                success: function (data) {
    //                    //                    setLoading(false);
    //                    //                    $("#dialog-upload-product-review").dialog('close');
    //                    $(tagToRefresh).empty();
    //                    $(data).appendTo(tagToRefresh);
    //                },
    //                error: function (data) {
    //                    //                    setLoading(false);
    //                    alert('Fail on uploading document');
    //                }
    //            });
    //            dlgUploadDocument.DoSomething();
    //            //window.location = href;
    //        }

    //    });

    //    $(document).on('click', '.cloudApplicationDocumentDelete', function () {
    //        var rowID = $(this).attr("id");


    //        var tagToRefresh = ".documents-container";

    //        $.ajax({
    //            url: 'DeleteDocument',
    //            type: 'POST',
    //            data: "rowID=" + rowID,
    //            //contentType:attr("enctype", "multipart/form-data"),

    //            //The request was a success.
    //            success: function (data) {
    //                //                    setLoading(false);
    //                //                    $("#dialog-upload-product-review").dialog('close');
    //                $(tagToRefresh).empty();
    //                $(data).appendTo(tagToRefresh);
    //            },
    //            error: function (data) {
    //                //                    setLoading(false);
    //                alert('Fail on deleting document');
    //            }
    //        });
    //        return false;
    //    });

    //    var dlgUploadDocument = {
    //        DoSomething: function () {
    //            $("#dialog-upload-document").dialog("open");
    //        }
    //    }

    //    // Initialize my dialog
    //    $("#dialog-upload-document").dialog({
    //        autoOpen: false,
    //        modal: true,
    //        width: 900,
    //        resizable: false,
    //        closeText: null,
    //        open: function (event, ui) {
    //            // Enable validation for unobtrusive stuffs
    //            //$(this).load(options.url, function () {
    //            //var theform = $('#uploadImageForm');
    //            //var theform = $('#registerApplicationForm');
    //            //$(this).appendTo($('#myform'));
    //            //$(this).parent().appendTo($('#registerApplicationForm'));
    //            //$(this).parent.empty();
    //            //var $jQval = $.validator;
    //            //$jQval.unobtrusive.parse($(this));
    //            //var updateTargetId = "";
    //            //var updateUrl = "";
    //            //wireUpForm(this, updateTargetId, updateUrl);
    //            //});

    //        }
    //    });


    //    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //    //DOCUMENTS




    //    //UPLOAD DOCUMENT BUTTON CLICK
    //    $(document).on('click', '#uploadDocumentFULLButton', function () {
    //        var postedFile = $('#PostedFile');
    //        if (postedFile[0].value != "") {
    //            return true;
    //        }
    //        else {
    //            return false;
    //        }

    //        if ($('#uploadDocumentForm').valid()) {
    //            return true;
    //        }
    //        else {
    //            return false;
    //        }
    //    });


    //    //$('#uploadDocumentAJAXButton', documentsContainerContext).click(function () {
    //    $(document).on('click', '#uploadDocumentAJAXButton', function () {
    //        //$('body').on('click', '#uploadDocumentAJAXButton', function () {


    //        //if ($('#dialog-upload-image').valid()) {
    //        //var test = $('#dialog-upload-product-review');
    //        //var serialize1 = $('#dialog-upload-product-review').serialize();
    //        //var serialize1 = $('.ui-dialog').serialize();
    //        var serialize2 = $('#uploadDocumentForm').serialize();
    //        tagToRefresh = ".user-documents-container";
    //        //var fileName = $('.file').val();
    //        //data: serialize1 + "&refreshResults=" + refresh + "&sortColumn=" + sortColumn + "&currentSortOrder=" + currentSortOrder,
    //        //setLoading(true);

    //        //var a = $('#xmyform').validate().form();
    //        //var b = $('#CloudApplicationRatingReviewerTitle').validate().valid();
    //        //var c = $.validator.unobtrusive.parse($('#uploadProductReviewForm'));

    //        if ($('#uploadDocumentForm').valid()) {

    //            $.ajax({
    //                url: 'UploadDocument',
    //                type: 'POST',
    //                data: serialize2,
    //                //contentType:attr("enctype", "multipart/form-data"),

    //                //The request was a success.
    //                success: function (data) {
    //                    //setLoading(false);
    //                    $("#dialog-upload-document").dialog('close');
    //                    //dlgRatingReviewCreated.DoSomething();
    //                    $(tagToRefresh).empty();
    //                    $(data).appendTo(tagToRefresh);

    //                    //RefreshUploadDocument();
    //                },
    //                error: function (data) {
    //                    //setLoading(false);
    //                    alert('Fail on uploading document');
    //                }
    //            });
    //        }
    //    });


    //    function RefreshUploadDocument() {
    //        var tagToRefresh = "#dialog-upload-document";
    //        $.ajax({
    //            url: 'RefreshUploadDocument',
    //            type: 'POST',
    //            //data: serialize2,
    //            //contentType:attr("enctype", "multipart/form-data"),

    //            //The request was a success.
    //            success: function (data) {
    //                //setLoading(false);
    //                $(tagToRefresh).empty();
    //                $(data).appendTo(tagToRefresh);
    //            },
    //            error: function (data) {
    //                setLoading(false);
    //                alert('Fail on uploading document');
    //            }
    //        });
    //    }












    //    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //    //PRODUCT REVIEWS CONTAINER


    //    var productReviewsContainerContext = $('.product-reviews-container');



    //    $(document).on('click', '#newProductReviewButton', function () {
    //        //$('body').on('click', '#newProductReviewButton', function () {
    //        RefreshUploadProductReview();
    //        dlgUploadProductReview.DoSomething();
    //    });



    //    $(document).on('click', '.product-reviews-container td:has(label)', function () {
    //        //$('body').on('click', '.product-reviews-container tr', function () {
    //        //$('.product-reviews-container tr').click(function () {
    //        var href = $(this).parent().find("a");
    //        if (href) {
    //            var rowID = href.attr("id");
    //            var tagToRefresh = "#dialog-upload-product-review";
    //            $.ajax({
    //                url: 'FindProductReview',
    //                type: 'POST',
    //                data: "rowID=" + rowID,
    //                //contentType:attr("enctype", "multipart/form-data"),

    //                //The request was a success.
    //                success: function (data) {
    //                    //                    setLoading(false);
    //                    //                    $("#dialog-upload-product-review").dialog('close');
    //                    $(tagToRefresh).empty();
    //                    $(data).appendTo(tagToRefresh);
    //                },
    //                error: function (data) {
    //                    //                    setLoading(false);
    //                    alert('Fail on uploading product review');
    //                }
    //            });
    //            dlgUploadProductReview.DoSomething();
    //            //window.location = href;
    //        }
    //    });


    //    $(document).on('click', '.cloudApplicationProductReviewDelete', function () {
    //        var rowID = $(this).attr("id");


    //        var tagToRefresh = ".product-reviews-container";

    //        $.ajax({
    //            url: 'DeleteProductReview',
    //            type: 'POST',
    //            data: "rowID=" + rowID,
    //            //contentType:attr("enctype", "multipart/form-data"),

    //            //The request was a success.
    //            success: function (data) {
    //                //                    setLoading(false);
    //                //                    $("#dialog-upload-product-review").dialog('close');
    //                $(tagToRefresh).empty();
    //                $(data).appendTo(tagToRefresh);
    //            },
    //            error: function (data) {
    //                //                    setLoading(false);
    //                alert('Fail on deleting product review');
    //            }
    //        });
    //        return false;
    //    });

    //    var dlgUploadProductReview = {
    //        DoSomething: function () {
    //            $("#dialog-upload-product-review").dialog("open");
    //        }
    //    }

    //    // Initialize my dialog
    //    $("#dialog-upload-product-review").dialog({
    //        autoOpen: false,
    //        modal: true,
    //        width: 950,
    //        resizable: false,
    //        closeText: null,
    //        open: function (event, ui) {
    //            // Enable validation for unobtrusive stuffs
    //            //$(this).load(options.url, function () {
    //            //var theform = $('#uploadImageForm');
    //            //var theform = $('#registerApplicationForm');
    //            //$(this).appendTo($('#myform'));
    //            //$(this).parent().appendTo($('#registerApplicationForm'));
    //            //$(this).parent.empty();
    //            //var $jQval = $.validator;
    //            //$jQval.unobtrusive.parse($(this));
    //            //var updateTargetId = "";
    //            //var updateUrl = "";
    //            //wireUpForm(this, updateTargetId, updateUrl);
    //            //});

    //        }
    //    });


    //    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //    //PRODUCT REVIEWS
    //    var productReviewContext = $('#dialog-upload-user-review');

    //    //fires when the upload product review button is clicked
    //    //$('body').on('click', '#uploadProductReviewAJAXButton', function () {
    //    $(document).on('click', '#uploadProductReviewAJAXButton', function () {


    //        //if ($('#dialog-upload-image').valid()) {
    //        //var test = $('#dialog-upload-product-review');
    //        //var serialize1 = $('#dialog-upload-product-review').serialize();
    //        //var serialize1 = $('.ui-dialog').serialize();
    //        var serialize2 = $('#uploadProductReviewForm').serialize();
    //        tagToRefresh = ".product-reviews-container";
    //        //var fileName = $('.file').val();
    //        //data: serialize1 + "&refreshResults=" + refresh + "&sortColumn=" + sortColumn + "&currentSortOrder=" + currentSortOrder,
    //        setLoading(true);

    //        //var a = $('#xmyform').validate().form();
    //        //var b = $('#CloudApplicationRatingReviewerTitle').validate().valid();
    //        //var c = $.validator.unobtrusive.parse($('#uploadProductReviewForm'));

    //        if ($('#uploadProductReviewForm').valid()) {

    //            $.ajax({
    //                url: 'UploadProductReview',
    //                type: 'POST',
    //                data: serialize2,
    //                //contentType:attr("enctype", "multipart/form-data"),

    //                //The request was a success.
    //                success: function (data) {
    //                    setLoading(false);
    //                    $("#dialog-upload-product-review").dialog('close');
    //                    //dlgRatingReviewCreated.DoSomething();
    //                    $(tagToRefresh).empty();
    //                    $(data).appendTo(tagToRefresh);

    //                    RefreshUploadProductReview();
    //                },
    //                error: function (data) {
    //                    setLoading(false);
    //                    alert('Fail on uploading product review');
    //                }
    //            });
    //        }
    //    });


    //    function RefreshUploadProductReview() {
    //        var tagToRefresh = "#dialog-upload-product-review";
    //        $.ajax({
    //            url: 'RefreshUploadProductReview',
    //            type: 'POST',
    //            //data: serialize2,
    //            //contentType:attr("enctype", "multipart/form-data"),

    //            //The request was a success.
    //            success: function (data) {
    //                //setLoading(false);
    //                $(tagToRefresh).empty();
    //                $(data).appendTo(tagToRefresh);
    //            },
    //            error: function (data) {
    //                setLoading(false);
    //                alert('Fail on uploading product review');
    //            }
    //        });
    //    }


    //fires when the VX dummy mode checkbox is changed
    $('body').on('change', '.dummyVXMode', function () {
        var dummyVXMode = $('.dummyVXMode');
        var dummyVXModeIsChecked = $(dummyVXMode).prop("checked");
        var dummyVXModeIsChecked2 = $(dummyVXMode).val();
        var dummyVXModeValue = (dummyVXModeIsChecked != null);
        dummyVXModeValue = dummyVXModeIsChecked;
        $.ajax({
            url: '/SetDummyVXMode',
            type: 'POST',
            data: "dummyVXMode=" + dummyVXModeValue,

            //The request was a success. Repopulate the div with new result set.
            success: function (data) {

            },
            error: function (data) {
            }
        });
    });

});
