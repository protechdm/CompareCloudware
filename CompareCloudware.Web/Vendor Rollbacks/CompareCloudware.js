//<script language="javascript" type="text/javascript"></script>

$(document).ready(function () {

    setResultsDisplay();
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

    //    $(document).ready(function () {
    setLoading(false);
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

    function toggleResults(obj) {
        //$('#displayAsSummary').click(function () {
        //alert("clicked");
        var classValue = $(obj).attr("class");
        //alert(classValue);
        var displayAsSummary = $('#displayAsSummary');
        if (classValue == "site-button-full") {
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
        if (classValue == "site-button-summary") {
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

    $('body').on('click', '.terms-checked', function () {
        return HaveTermsBeenChecked();
    });

    $('body').on('click', '.rating-review-terms-checked', function () {
        return HaveRatingReviewTermsBeenChecked();
    });

    function HaveTermsBeenChecked() {
        //alert('terms');
        var terms = $(".terms");
        var isChecked = terms.prop("checked");
        if (!isChecked) {
            AlertToCheckTCs();
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

    function AlertToCheckTCs() {
        //alert("Please accept the terms & conditions to proceed");
        dlgTC.DoSomething();
    }

    var dlgTC = {
        DoSomething: function () {
            $("#dialog-message-tc").dialog("open");
        }
    }

    // Initialize my dialog
    $("#dialog-message-tc").dialog({
        autoOpen: false,
        modal: true,
        resizable: false,
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
        }

        //        buttons: [
        //            {
        //                text: "Ok"
        //                //, click: function () { $(this).dialog("close"); } 
        //            } 
        //        ]
    });

    //fires when a dropdown filter is changed
    $('body').on('change', 'select.filterParameter', function () {
        //$('select.filterParameter').change(function () {

        setLoading(true);
        var text = this.options[this.selectedIndex].text;
        //alert(text);
        //alert(this.selectedIndex);
        //alert($('#chosenCategoryID option[this.selectedIndex]').attr("value"));
        //alert($('#previouslyChosenCategoryID').attr("value"));
        //alert($('#chosenCategoryID option:selected').attr("value"));
        //$(this).parent('form:first').submit();
        //$('#main form').submit();
        //return;

        var previouslyChosenCategoryID = $('#previouslyChosenCategoryID').attr("value");
        var chosenCategoryID = $('#chosenCategoryID option:selected').attr("value");
        var tagToRefresh;
        //alert(previouslyChosenCategoryID);
        //alert(chosenCategoryID);
        var refresh;
        //if (previouslyChosenCategoryID != chosenCategoryID) {
        refresh = true;
        var sortColumn = $('#currentSortOrder').val();
        var currentSortOrder = $('#currentSortOrder').val();
        //tagToRefresh = ".search-filters-container-inner";
        tagToRefresh = ".search-page-container";
        var serialize1 = $('#main form').serialize();
        $.ajax({
            //url: '/Home/SearchFiltersPartial',
            url: 'SearchFiltersPartial',
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
                $(data).appendTo(tagToRefresh);
                setResultsDisplay();
                //collapseFilterGroups("true");
                collapseAllFilterGroups();
                setLoading(false);
            },
            error: function (data) {
                setLoading(false);
                alert('Fail on dropdown');
            }
        });
        //}
    });

    //fires when a checkbox filter is changed
    $('body').on('change', 'input.filterParameter', function () {
        //$('input.filterParameter').change(function () {
        //alert("postback");
        //$(this).parent('form:first').submit();
        //$('#main form').submit();
        debugger;
        var serialize1 = $('#main form').serialize();
        //var serialize2 = JSON.stringify($('#main'));
        //var serialize3 = $('#main form').serializeArray();
        //var sortColumn = $('#currentSortOrder').val();
        //var currentSortOrder = $('#currentSortOrder').val();

        setLoading(true);

        $.ajax({
            //url: '/Home/SearchResultsPartial',
            url: 'SearchResultsPartial',
            //url: 'TestJSON',
            type: 'POST',
            //data: JSON.stringify("jsonData"),
            //data: $('#main form').serialize(),
            //data: "{ model: " + serialize2 + "}",
            //data: serialize1,
            //data: JSON.stringify(serialize1),
            //dataType: 'json',
            //contentType: 'application/json; charset=utf-8',
            //data: "{ model: " + serialize1 + ", sortColumn: sortColumn, currentSortOrder: currentSortOrder }",
            //data: { model: serialize1, sortColumn: sortColumn, currentSortOrder: currentSortOrder },
            data: serialize1,

            //The request was a success. Repopulate the div with new result set.
            success: function (data) {
                //$("#Content").empty();
                //$(data).hide().appendTo('#Content').slideDown();
                $(".search-results-container-outer").empty();
                $(data).appendTo(".search-results-container-outer");

                $("#searchResultsCount").text($("#searchResultsCountHidden").val());
                //alert($("#searchResultsCount").val());

                if ($('#displayAsSummary').attr("checked") == "checked") {
                    //alert("checked");
                    $('#resultsFull').css("visibility", "hidden");
                    $('#resultsSummary').css("visibility", "visible");
                }
                else {
                    //alert("not checked");
                    $('#resultsFull').css("visibility", "visible");
                    $('#resultsSummary').css("visibility", "hidden");
                }
                setLoading(false);

            },
            error: function (data) {
                setLoading(false);
                alert('Fail on checkbox');
            }
        });
    });







    //fires when a sort column is clicked
    $('body').on('click', '.search-results-sort-column label', function () {
        //$('input.filterParameter').change(function () {
        //alert("postback");
        //$(this).parent('form:first').submit();
        //$('#main form').submit();

        setLoading(true);
        var sortColumn = $(this).attr("id");
        var currentSortOrder = $('#currentSortOrder').val();
        var serialize1 = $('#main form').serialize();
        var refresh = false;
        $.ajax({
            //url: '/Home/SearchResultsPartial',
            url: 'SearchResultsPartial',
            type: 'POST',
            //data: JSON.stringify("jsonData"),
            //data: $('#main form').serialize(),
            //data: { sortColumn: sortColumn, currentSortOrder: currentSortOrder },
            data: serialize1 + "&refreshResults=" + refresh + "&sortColumn=" + sortColumn + "&currentSortOrder=" + currentSortOrder,
            //dataType: 'html',
            //contentType: 'application/json',

            //The request was a success. Repopulate the div with new result set.
            success: function (data) {
                //$("#Content").empty();
                //$(data).hide().appendTo('#Content').slideDown();

                $(".search-results-container-outer").empty();
                $(data).appendTo(".search-results-container-outer");

                $("#searchResultsCount").text($("#searchResultsCountHidden").val());
                //alert($("#searchResultsCount").val());

                setResultsDisplay();

                //                //if ($('#displayAsSummary').attr("checked") == "checked") {
                //                if ($('#displayAsSummary').attr("value") == "True") {
                //                    //alert("checked");
                //                    $('#resultsFull').css("visibility", "hidden");
                //                    $('#resultsSummary').css("visibility", "visible");
                //                }
                //                else {
                //                    //alert("not checked");
                //                    $('#resultsFull').css("visibility", "visible");
                //                    $('#resultsSummary').css("visibility", "hidden");
                //                }
                setLoading(false);

            },
            error: function (data) {
                setLoading(false);
                alert('Fail on checkbox');
            }
        });
    });





    //fires when a search navigation button is clicked
    $('body').on('click', '.navigate-search-results', function () {

        setLoading(true);
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

        if (nextPageToRequest != currentPageNumber && nextPageToRequest > 0 && nextPageToRequest <= pageCount) {
            $.ajax({
                url: 'GetNextSearchResultsPage',
                type: 'POST',
                data: serialize1 + "&page=" + nextPageToRequest,

                //The request was a success. Repopulate the div with new result set.
                success: function (data) {
                    $(".search-results-container-outer").empty();
                    $(data).appendTo(".search-results-container-outer");
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
                    setLoading(false);
                    $('html, body').animate({ scrollTop: 0 }, 'fast');
                },
                error: function (data) {
                    setLoading(false);
                    alert('Fail on search navigate');
                }
            });
        }
        else {
            setLoading(false);
            //alert("Same page");
        }
    });





    //fires when a GLOBAL search navigation button is clicked
    $('body').on('click', '.navigate-global-search-results', function () {

        setLoading(true);
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
            url: 'GetNextGlobalSearchResultsPage',
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
                setLoading(false);
                $('html, body').animate({ scrollTop: 0 }, 'fast');
            },
            error: function (data) {
                setLoading(false);
                alert('Fail on search navigate');
            }
        });
    });




    //var $jQval = $.validator;
    //$jQval.unobtrusive.parse($(this));

    $.validator.unobtrusive.parse($('#main'));

    //fires when the application request (Free Trial/Buy Now) button is clicked
    $('body').on('click', '#applicationRequestButton', function () {
        //$('input.filterParameter').change(function () {
        //alert("postback");
        //$(this).parent('form:first').submit();
        //$('#main form').submit();
        //var x = $('#main').validate().form();

        //        if ($('#myform').valid()) {

        if (!HaveTermsBeenChecked()) {
            //AlertToCheckTCs();
            return false;
        }
        if ($('#main form').valid()) {

            var serialize1 = $('#main form').serialize();
            //var serialize2 = JSON.stringify($('#main'));
            //var serialize3 = $('#main form').serializeArray();
            var sortColumn = $('#currentSortOrder').val();
            var currentSortOrder = $('#currentSortOrder').val();

            setLoading(true);

            $.ajax({
                //url: '/Home/SearchResultsPartial',
                url: 'InsertApplicationRequest',
                //url: 'TestJSON',
                type: 'POST',
                //data: JSON.stringify("jsonData"),
                //data: $('#main form').serialize(),
                //data: "{ model: " + serialize2 + "}",
                //data: serialize1,
                //data: JSON.stringify(serialize1),
                //dataType: 'json',
                //contentType: 'application/json; charset=utf-8',
                //data: "{ model: " + serialize1 + ", sortColumn: sortColumn, currentSortOrder: currentSortOrder }",
                //data: { model: serialize1, sortColumn: sortColumn, currentSortOrder: currentSortOrder },
                data: serialize1,

                //The request was a success.
                success: function (data) {
                    setLoading(false);
                    dlgApplicationSubmit.DoSomething();
                },
                error: function (data) {
                    setLoading(false);
                    alert('Fail on application request');
                }
            });
        }
    });


    var dlgApplicationSubmit = {
        DoSomething: function () {
            $("#dialog-message-application-submission-complete").dialog("open");
        }
    }

    // Initialize my dialog
    $("#dialog-message-application-submission-complete").dialog({
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
        }
    });










    //fires when the email page button is clicked
    $('body').on('click', '#emailApplicationButton', function () {

        //alert("Hit email button");
        if (!HaveTermsBeenChecked()) {
            //AlertToCheckTCs();
            return false;
        }
        //debugger;
        if ($('#main form').valid()) {

            var serialize1 = $('#main form').serialize();

            setLoading(true);

            $.ajax({
                url: 'EmailApplicationRequest',
                type: 'POST',
                data: serialize1,

                //The request was a success.
                success: function (data) {
                    setLoading(false);
                    dlgApplicationEmail.DoSomething();
                },
                error: function (data) {
                    setLoading(false);
                    alert('Fail on application email');
                }
            });
        }
        else {
            $(".input-validation-error:first").focus();
            $(".request-types option[value='3']").attr("selected", "selected");

        }
    });


    var dlgApplicationEmail = {
        DoSomething: function () {
            $("#dialog-message-application-email-complete").dialog("open");
        }
    }

    // Initialize my dialog
    $("#dialog-message-application-email-complete").dialog({
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
            "Compare Again": function (event, ui) {
                $(this).dialog("close");
                window.location.href = "BackToSearchResults";
            }
            //close: function (event, ui) { window.location.href = "SearchPage"; 
        }
    });













    //fires when the create review button is clicked
    $('body').on('click', '#createReviewButton', function () {
        dlgInputReview.DoSomething();
    });


    var dlgInputReview = {
        DoSomething: function () {
            $("#dialog-input-review").dialog("open");
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
        debugger;
        //var a = $('#xmyform').validate().form();
        //var b = $('#CloudApplicationRatingReviewerTitle').validate().valid();
        //var c = $.validator.unobtrusive.parse($('#xmyform'));
        if (!HaveRatingReviewTermsBeenChecked()) {
            //AlertToCheckTCs();
            return false;
        }

        if ($('#xmyform').valid()) {
            var serialize1 = $('#myform').serialize();

            setLoading(true);

            $.ajax({
                url: 'UserReview',
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
                alert('the form is valid');
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








































//    //VENDOR INTERFACE

//    //fires when the upload video button is clicked
//    $('body').on('click', '#uploadVideoButton', function () {
//        //debugger;
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
//        //debugger;
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
//                //debugger;
//                //setLoading(false);


//                $("#dialog-upload-video").dialog('close');
//                //dlgRatingReviewCreated.DoSomething();

//                //debugger;
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
//        //debugger;
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
//                //debugger;
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
//                debugger;
//                //setLoading(false);
//                alert('Fail on playing video');
//            }
//        });

//    });



//    //NOT USED!!!!
//    //What happens if the File Format changes?
//    //$('#CloudApplicationVideoExtensions_ChosenValue', videoUploadContext).click(function (evt) {
//    $('.xradCustomRadioButtonList', videoUploadContext).click(function (evt) {


//        debugger;
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
//                debugger;
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
//                debugger;
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
//        debugger;
//        RefreshUploadUserReview();
//        dlgUploadUserReview.DoSomething();
//    });

//    //$('.user-reviews-container tr', userReviewsContainerContext).click(function () {
//    $(document).on('click', '.user-reviews-container td:has(label)', function () {
//        //$('body').on('click', '.user-reviews-container tr', function () {
//        //$('.product-reviews-container tr').click(function () {
//        debugger;
//        //var href = $(this).find("a").attr("href");
//        var href = $(this).parent().find("a");
//        if (href) {
//            //var href2 = $(this).find("a");
//            var rowID = href.attr("id");
//            //alert(rowID);


//            //debugger;


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
//        debugger;
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


//        debugger;
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
//                //debugger;
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
//        //debugger;
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
//        debugger;
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
//        //debugger;
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

//        //debugger;

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
//                //debugger;
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
//        debugger;
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
//        debugger;
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

//        //debugger;

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
//                //debugger;
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



});
