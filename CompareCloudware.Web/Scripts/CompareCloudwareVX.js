//<script language="javascript" type="text/javascript"></script>

$(document).ready(function () {

    //VENDOR INTERFACE

    function InitBindings() {
        videoDialogButtonContext = $('.application-video-container');
        $('#uploadVideoButton', videoDialogButtonContext).off("click");
        $('#uploadVideoButton', videoDialogButtonContext).click(function (evt) {
            dlgUploadVideo.DoSomething();
        });

        userReviewsContainerContext = $('.user-reviews-container');
        $('#newUserReviewButton', userReviewsContainerContext).off("click");
        $('#newUserReviewButton', userReviewsContainerContext).click(function () {
            debugger;
            RefreshUploadUserReview();
            dlgUploadUserReview.DoSomething();
        });

        productReviewsContainerContext = $('.product-reviews-container');
        $('#newProductReviewButton', productReviewsContainerContext).off("click");
        $('#newProductReviewButton', productReviewsContainerContext).click(function () {
            RefreshUploadProductReview();
            dlgUploadProductReview.DoSomething();
        });

        documentsContainerContext = $('.documents-container');
        $('#newDocumentButton', documentsContainerContext).off("click");
        $('#newDocumentButton', documentsContainerContext).click(function () {
            //$(document).on('click', '#newDocumentButton', function () {
            SaveSerializedFormToSession(SerializeForm());
            RefreshUploadDocument();
            dlgUploadDocument.DoSomething();
        });

        videosContainerContext = $('.videos-container');
        $('#uploadVideoButton', videosContainerContext).off("click");
        $('#uploadVideoButton', videosContainerContext).click(function () {
            //RefreshUploadUserReview();
            dlgUploadVideo.DoSomething();
        });

    }

    function SerializeForm() {
        var formSerialized = $('#registerApplicationForm').serialize();
        return formSerialized;
    }

    function SaveSerializedFormToSession(serializedForm) {
        $.ajax({
            url: 'SaveSerializedFormToSession',
            type: 'POST',
            data: serializedForm,
            success: function (data) {
            },
            error: function (data) {
                setLoading(false);
                alert('Fail on serializing form');
            }

        });
    }

    ///////////////////////////////////////////////
    //               VIDEO                       //
    ///////////////////////////////////////////////

    var videoDialogButtonContext = $('.application-video-container');
    var videosContainerContext = $('.videos-container');


    var dlgUploadVideo = {
        DoSomething: function () {
            $("#dialog-upload-video").dialog("open");
        }
    }

    $("#dialog-upload-video").dialog({
        autoOpen: false,
        modal: true,
        width: 1200,
        resizable: false,
        closeText: null,
        open: function (event, ui) {
            var $jQval = $.validator;
            $jQval.unobtrusive.parse($(this));
        }

    });


    //fires when the upload video button is clicked
    var videoUploadContainerContext = $('.upload-video-input-container');
    //$('body').on('click', '#uploadVideoAJAXButton', function () {
    //$('#uploadVideoAJAXButton', videoUploadContainerContext).click(function (evt) {
    $(videoUploadContainerContext).on('click', '#uploadVideoAJAXButton', function () {
        var tagToRefresh = ".application-video-container";
        //var serialize1 = $('#uploadVideoForm').serialize();

        var serialize1 = $(".videos-container :input").serialize();
        var serialize2 = $('#uploadVideoForm').serialize();
        //var rowID = $('#RowID', userReviewContext).val();
        var tagToRefresh = ".videos-container";
        //debugger;
        $.ajax({
            url: 'UploadVideo',
            type: 'POST',
            data: serialize1 + "&" + serialize2,
            success: function (data) {
                //debugger;
                $("#dialog-upload-video").dialog('close');
                $(tagToRefresh).empty();
                //$(data).appendTo(tagToRefresh);
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                InitBindings();
            },
            error: function (data) {
                setLoading(false);
                alert('Fail on uploading video');
            }

        });
        InitBindings();
    });


    var videoUploadContext = $('#uploadVideoForm');
    $('#playVideoButton', videoUploadContainerContext).click(function (evt) {
        var serialize = videoUploadContext.serialize();
        var url = this.value;
        //var tagToRefresh = $('#video-cut', videoUploadContext);
        var tagToRefresh = $('#videoContainer', videoUploadContext);
        $.ajax({
            url: 'PlayVideo',
            type: 'POST',
            data: serialize,
            success: function (data) {
                $(tagToRefresh).empty();
                //$(data).appendTo(tagToRefresh);
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                InitBindings();
            },
            error: function (data) {
                debugger;
                alert('Fail on playing video');
            }
        });

    });







    ///////////////////////////////////////////////
    //           USER REVIEWS CONTAINER          //
    ///////////////////////////////////////////////


    var userReviewsContainerContext = $('.user-reviews-container');

    //$('.user-reviews-container tr', userReviewsContainerContext).click(function () {
    //$(document).on('click', '.user-reviews-container td:has(label)', function () {
    //$(userReviewsContainerContext).on('click', '.user-reviews-container td:has(label)', function () {
    $(userReviewsContainerContext).on('click', 'td:has(label)', function () {
        var href = $(this).parent().find("a");
        if (href) {
            var rowID = href.attr("id");
            var tagToRefresh = "#dialog-upload-user-review";
            var serialize1 = $(".user-reviews-container :input").serialize();
            debugger;
            $.ajax({
                url: 'FindUserReview',
                type: 'POST',
                //data: "rowID=" + rowID,
                data: serialize1 + "&rowID=" + rowID,
                success: function (data) {
                    $(tagToRefresh).empty();
                    //$(data).appendTo(tagToRefresh);
                    $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                    InitBindings();
                },
                error: function (data) {
                    alert('Fail on uploading user review');
                }
            });
            dlgUploadUserReview.DoSomething();
        }
    });

    //$(document).on('click', '.cloudApplicationUserReviewDelete', function () {
    $(userReviewsContainerContext).on('click', '.cloudApplicationUserReviewDelete', function () {
        var cloudApplicationID = $('#CloudApplicationID').val();
        var rowID = $(this).attr("id");
        var tagToRefresh = ".user-reviews-container";
        var serialize1 = $(".user-reviews-container :input").serialize();
        //var serialize1 = $("#registerApplicationForm").serialize();
        debugger;
        $.ajax({
            url: 'DeleteUserReview',
            type: 'POST',
            //data: "cloudApplicationDeleteID=" + cloudApplicationID + "&rowDeleteID=" + rowID + "&viewDataUserReviews=" + serialize1,
            //dataType: 'json',
            data: serialize1 + "&rowDeleteID=" + rowID + "&cloudApplicationDeleteID=" + cloudApplicationID,
            //data: serialize1,
            success: function (data) {
                $(tagToRefresh).empty();
                //$(data).appendTo(tagToRefresh);
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                InitBindings();
            },
            error: function (data) {
                alert('Fail on deleting user review');
            }
        });
        return false;
    });

    var dlgUploadUserReview = {
        DoSomething: function () {
            $("#dialog-upload-user-review").dialog("open");
        }
    }

    $("#dialog-upload-user-review").dialog({
        autoOpen: false,
        modal: true,
        width: 750,
        resizable: false,
        closeText: null,
        open: function (event, ui) {
        }
    });


    ///////////////////////////////////////////////
    //                USER REVIEWS               //
    ///////////////////////////////////////////////

    var userReviewContext = $('#dialog-upload-user-review');

    //UPLOAD USER REVIEW CLICK
    //$('#uploadUserReviewAJAXButton', userReviewContext).click(function () {
    $(userReviewContext).on('click', '#uploadUserReviewAJAXButton', function () {
        debugger;
        var serialize1 = $(".user-reviews-container :input").serialize();
        var serialize2 = $('#uploadUserReviewForm').serialize();
        var rowID = $('#RowID', userReviewContext).val();
        var tagToRefresh = ".user-reviews-container";
        if ($('#uploadUserReviewForm').valid()) {

            $.ajax({
                url: 'UploadUserReview',
                type: 'POST',
                //data: serialize2,
                //data: serialize1 + "&viewDataUserReview=" + serialize2 + "&rowUploadID=" + rowID + "&cloudApplicationUploadID=" + cloudApplicationID,
                //data: serialize1 + "&rowUploadID=" + rowID + "&cloudApplicationUploadID=" + cloudApplicationID,
                data: serialize1 + "&" + serialize2 + "&rowUploadID=" + rowID,
                success: function (data) {
                    debugger;
                    $("#dialog-upload-user-review").dialog('close');
                    $(tagToRefresh).empty();
                    //$(data).appendTo(tagToRefresh);
                    $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                    RefreshUploadUserReview();
                    InitBindings();
                },
                error: function (data) {
                    alert('Fail on uploading user review');
                }
            });
        }
    });

    function RefreshUploadUserReview() {
        var tagToRefresh = "#dialog-upload-user-review";
        var serialize1 = $(".user-reviews-container :input").serialize();
        $.ajax({
            url: 'RefreshUploadUserReview',
            type: 'POST',
            data: serialize1,
            //contentType:attr("enctype", "multipart/form-data"),

            //The request was a success.
            success: function (data) {
                debugger;
                //setLoading(false);
                $(tagToRefresh).empty();
                //$(data).appendTo(tagToRefresh);
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
            },
            error: function (data) {
                //setLoading(false);
                alert('Fail on uploading user review');
            }
        });
    }










    ///////////////////////////////////////////////
    //            DOCUMENTS CONTAINER            //
    ///////////////////////////////////////////////


    var documentsContainerContext = $('.documents-container');

    //$('body').on('click', '.documents-container tr', function () {
    $(documentsContainerContext).on('click', 'td:has(label)', function () {
        var tagToRefresh = "#dialog-upload-document";
        var serialize1 = $(".documents-container :input").serialize();
        var href = $(this).parent().find("a");
        if (href) {
            var rowID = href.attr("id");

            $.ajax({
                url: 'FindDocument',
                type: 'POST',
                //data: "rowID=" + rowID,
                data: serialize1 + "&rowID=" + rowID,
                success: function (data) {
                    $(tagToRefresh).empty();
                    //$(data).appendTo(tagToRefresh);
                    $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                },
                error: function (data) {
                    alert('Fail on uploading document');
                }
            });
            dlgUploadDocument.DoSomething();
        }

    });

    $(documentsContainerContext).on('click', '.cloudApplicationDocumentDelete', function () {
        var rowID = $(this).attr("id");
        var cloudApplicationID = $('#CloudApplicationID').val();
        var tagToRefresh = ".documents-container";
        var serialize1 = $(".documents-container :input").serialize();
        $.ajax({
            url: 'DeleteDocument',
            type: 'POST',
            //data: "cloudApplicationID=" + cloudApplicationID + "&rowID=" + rowID,
            data: serialize1 + "&rowDeleteID=" + rowID + "&cloudApplicationDeleteID=" + cloudApplicationID,
            success: function (data) {
                $(tagToRefresh).empty();
                //$(data).appendTo(tagToRefresh);
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                InitBindings();
            },
            error: function (data) {
                alert('Fail on deleting document');
            }
        });
        return false;
    });

    var dlgUploadDocument = {
        DoSomething: function () {
            $("#dialog-upload-document").dialog("open");
        }
    }

    // Initialize my dialog
    $("#dialog-upload-document").dialog({
        autoOpen: false,
        modal: true,
        width: 900,
        resizable: false,
        closeText: null,
        open: function (event, ui) {
        }
    });


    ///////////////////////////////////////////////
    //                 DOCUMENTS                 //
    ///////////////////////////////////////////////


    var documentContext = $('#dialog-upload-document');


    //UPLOAD DOCUMENT BUTTON CLICK
    //$(document).on('click', '#uploadDocumentFULLButton', function () {
    $(documentContext).on('click', '#uploadDocumentFULLButton', function () {
        debugger;
        var postedFile = $('#CloudApplicationDocumentPostedFile');
        if (postedFile[0].value != "") {
            return true;
        }
        else {
            return false;
        }

        if ($('#uploadDocumentForm').valid()) {
            return true;
        }
        else {
            return false;
        }
    });

    //            //NOT USED
    //            //$('#uploadDocumentAJAXButton', documentsContainerContext).click(function () {
    //            $(document).on('click', '#uploadDocumentAJAXButton', function () {
    //                //$('body').on('click', '#uploadDocumentAJAXButton', function () {

    //                debugger;

    //                //if ($('#dialog-upload-image').valid()) {
    //                //var test = $('#dialog-upload-product-review');
    //                //var serialize1 = $('#dialog-upload-product-review').serialize();
    //                //var serialize1 = $('.ui-dialog').serialize();
    //                var serialize2 = $('#uploadDocumentForm').serialize();
    //                tagToRefresh = ".user-documents-container";
    //                //var fileName = $('.file').val();
    //                //data: serialize1 + "&refreshResults=" + refresh + "&sortColumn=" + sortColumn + "&currentSortOrder=" + currentSortOrder,
    //                //setLoading(true);

    //                //var a = $('#xmyform').validate().form();
    //                //var b = $('#CloudApplicationRatingReviewerTitle').validate().valid();
    //                //var c = $.validator.unobtrusive.parse($('#uploadProductReviewForm'));

    //                if ($('#uploadDocumentForm').valid()) {

    //                    $.ajax({
    //                        url: 'UploadDocument',
    //                        type: 'POST',
    //                        data: serialize2,
    //                        //contentType:attr("enctype", "multipart/form-data"),

    //                        //The request was a success.
    //                        success: function (data) {
    //                            //setLoading(false);
    //                            $("#dialog-upload-document").dialog('close');
    //                            //dlgRatingReviewCreated.DoSomething();
    //                            $(tagToRefresh).empty();
    //                            $(data).appendTo(tagToRefresh);

    //                            //RefreshUploadDocument();
    //                        },
    //                        error: function (data) {
    //                            //setLoading(false);
    //                            alert('Fail on uploading document');
    //                        }
    //                    });
    //                }
    //            });


    function RefreshUploadDocument() {
        var tagToRefresh = "#dialog-upload-document";
        var serialize1 = $(".documents-container :input").serialize();
        $.ajax({
            url: 'RefreshUploadDocument',
            type: 'POST',
            data: serialize1,
            success: function (data) {
                $(tagToRefresh).empty();
                //$(data).appendTo(tagToRefresh);
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
            },
            error: function (data) {
                alert('Fail on uploading document');
            }
        });
    }









    ///////////////////////////////////////////////
    //         PRODUCT REVIEWS CONTAINER         //
    ///////////////////////////////////////////////

    var productReviewsContainerContext = $('.product-reviews-container');

    $(productReviewsContainerContext).on('click', 'td:has(label)', function () {
        var href = $(this).parent().find("a");
        if (href) {
            var rowID = href.attr("id");
            var tagToRefresh = "#dialog-upload-product-review";
            var serialize1 = $(".product-reviews-container :input").serialize();
            $.ajax({
                url: 'FindProductReview',
                type: 'POST',
                //data: "rowID=" + rowID,
                data: serialize1 + "&rowID=" + rowID,
                success: function (data) {
                    $(tagToRefresh).empty();
                    //$(data).appendTo(tagToRefresh);
                    $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                    InitBindings();
                },
                error: function (data) {
                    alert('Fail on uploading product review');
                }
            });
            dlgUploadProductReview.DoSomething();
        }
    });


    $(productReviewsContainerContext).on('click', '.cloudApplicationProductReviewDelete', function () {
        //debugger;
        var rowID = $(this).attr("id");
        var cloudApplicationID = $('#CloudApplicationID').val();
        var tagToRefresh = ".product-reviews-container";
        var serialize1 = $(".product-reviews-container :input").serialize();
        debugger;
        $.ajax({
            url: 'DeleteProductReview',
            type: 'POST',
            //data: "cloudApplicationID=" + cloudApplicationID + "&rowID=" + rowID,
            data: serialize1 + "&rowDeleteID=" + rowID + "&cloudApplicationDeleteID=" + cloudApplicationID,
            success: function (data) {
                $(tagToRefresh).empty();
                //$(data).appendTo(tagToRefresh);
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                InitBindings();
            },
            error: function (data) {
                alert('Fail on deleting product review');
            }
        });
        return false;
    });

    var dlgUploadProductReview = {
        DoSomething: function () {
            $("#dialog-upload-product-review").dialog("open");
        }
    }

    $("#dialog-upload-product-review").dialog({
        autoOpen: false,
        modal: true,
        width: 950,
        resizable: false,
        closeText: null,
        open: function (event, ui) {
        }
    });


    ///////////////////////////////////////////////
    //               PRODUCT REVIEW              //
    ///////////////////////////////////////////////

    var productReviewContext = $('#dialog-upload-product-review');

    //fires when the upload product review button is clicked
    $(productReviewContext).on('click', '#uploadProductReviewAJAXButton', function () {
        var serialize1 = $(".product-reviews-container :input").serialize();
        var rowID = $('#RowID', productReviewContext).val();
        var serialize2 = $('#uploadProductReviewForm').serialize();
        debugger;
        tagToRefresh = ".product-reviews-container";
        if ($('#uploadProductReviewForm').valid()) {
            $.ajax({
                url: 'UploadProductReview',
                type: 'POST',
                //                data: serialize2,
                data: serialize1 + "&" + serialize2 + "&rowUploadID=" + rowID,
                success: function (data) {
                    $("#dialog-upload-product-review").dialog('close');
                    $(tagToRefresh).empty();
                    //$(data).appendTo(tagToRefresh);
                    $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                    RefreshUploadProductReview();
                    InitBindings();
                },
                error: function (data) {
                    alert('Fail on uploading product review');
                }
            });
        }
    });


    function RefreshUploadProductReview() {
        var tagToRefresh = "#dialog-upload-product-review";
        debugger;
        var serialize1 = $(".product-reviews-container :input").serialize();
        $.ajax({
            url: 'RefreshUploadProductReview',
            type: 'POST',
            data: serialize1,
            success: function (data) {
                $(tagToRefresh).empty();
                $(jQuery.parseHTML(data)).appendTo(tagToRefresh);
                //$(data).appendTo(tagToRefresh);
            },
            error: function (data) {
                alert('Fail on uploading product review');
            }
        });
    }



    $('#registerApplicationForm').on('click', 'div.application-input-group-header', function () {
        //debugger;
        //$('div.search-filters-container-inner:eq(0)> div.search-filter-group-header').click(function () {
        //alert("click");
        //var t = $(this).parent().parent().next();
        //var t = $(this).find(".container-slide");
        var t = $(this).next();

        //.find(".container-slide");
        $(t).slideToggle('fast');

        //$(t).next().slideToggle('fast');
    });


    $('#registerApplicationForm').on('click', 'div.search-filters-container-inner:eq(0)> div.search-filter-group-header', function () {
        //$('div.search-filters-container-inner:eq(0)> div.search-filter-group-header').click(function () {
        debugger;
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

    $('#registerApplicationForm').on('click', 'div.content-data-header', function () {
        //$('div.search-filters-container-inner:eq(0)> div.search-filter-group-header').click(function () {
        //alert("click");
        debugger;
        var t = $(this).parent().parent().next();
        $(t).slideToggle('fast');

        //$(t).next().slideToggle('fast');
    });

    function collapseAllFilterGroups() {
        collapseFilterGroups($('.header-vx-features'), $('.application-features-container'));
        collapseFilterGroups($('.header-vx-social-networking'), $('.social-networking-container'));
        collapseFilterGroups($('.header-vx-product-reviews'), $('.product-reviews-container'));
        collapseFilterGroups($('.header-vx-user-reviews'), $('.user-reviews-container'));
        collapseFilterGroups($('.header-vx-documents'), $('.documents-container'));
        collapseFilterGroups($('.header-vx-application-logo'), $('.application-logo-container'));
        collapseFilterGroups($('.header-vx-video'), $('.application-video-container'));
        collapseFilterGroups($('.header-vx-vendor-main'), $('.vendor-main-container'));
        collapseFilterGroups($('.header-vx-categories'), $('.application-categories-container'));
        collapseFilterGroups($('.header-vx-costs'), $('.application-costs-container'));
        collapseFilterGroups($('.header-vx-service-overview'), $('.service-overview-container'));
        collapseFilterGroups($('.header-vx-applications'), $('.application-applications-container'));
        collapseFilterGroups($('.header-vx-operating-systems'), $('.application-operating-systems-container'));
        collapseFilterGroups($('.header-vx-support-types'), $('.application-support-types-container'));
        collapseFilterGroups($('.header-vx-support-days'), $('.application-support-days-container'));
        //collapseFilterGroups($('.header-vx-support-hours'), $('.application-support-hours-container'));
        collapseFilterGroups($('.header-vx-support'), $('.application-support-container'));
        collapseFilterGroups($('.header-vx-support-territories'), $('.application-support-territories-container'));
        collapseFilterGroups($('.header-vx-mobile-platforms'), $('.application-mobile-platforms-container'));
        collapseFilterGroups($('.header-vx-browsers'), $('.application-browsers-container'));
        collapseFilterGroups($('.header-vx-languages'), $('.application-languages-container'));
        collapseFilterGroups($('.header-vx-users'), $('.application-users-container'));
        //collapseFilterGroups($('.header-vx-minimum-users'), $('.application-minimum-users-container'));
        //collapseFilterGroups($('.header-vx-maximum-users'), $('.application-maximum-users-container'));
        collapseFilterGroups($('.header-vx-video-training'), $('.application-video-training-container'));
        collapseFilterGroups($('.header-vx-free-trial-period'), $('.application-free-trial-period-container'));
        collapseFilterGroups($('.header-vx-setup-fee'), $('.application-setup-fee-container'));
        collapseFilterGroups($('.header-vx-minimum-contract'), $('.application-minimum-contract-container'));
        collapseFilterGroups($('.header-vx-payment'), $('.application-payment-container'));
        collapseFilterGroups($('.header-vx-payment-frequency'), $('.application-payment-frequency-container'));
        collapseFilterGroups($('.header-vx-payment-options'), $('.application-payment-options-container'));
        collapseFilterGroups($('.header-vx-currency'), $('.application-currency-container'));
        collapseFilterGroups($('.header-vx-timezone'), $('.application-timezone-container'));
        collapseFilterGroups($('.header-vx-status'), $('.application-status-container'));
    }

    function collapseFilterGroups(objectToCollapse, filtersToCollapse) {
        //debugger;
        var isCollapsed = $(objectToCollapse).attr("value");
        var test = $(filtersToCollapse).css("display");
        var collapse = ($(filtersToCollapse).css("display") != "block");
        collapse = true;
        if (collapse == true) {
            $(objectToCollapse).next().hide();
        }
        else {
            $(objectToCollapse).next().show();
        }
    }

    $('#registerApplicationForm').on('click', 'input:submit', function () {
        setLoading(true);
    });

    function setLoading(visibility) {
        //debugger;
        if (visibility) {
            //alert("checked");
            $('.loading').css("visibility", "visible");
        }
        else {
            //alert("not checked");
            $('.loading').css("visibility", "hidden");
        }
    }

    function setVideoIFrame() {
        //debugger;
        var iFrame = $("#theVideo");
        if (iFrame != null) {
            var theObject = $("object", iFrame);
            if (theObject != null) {
                var objectHeight = $(theObject).attr("height");
                var objectWidth = $(theObject).attr("width");
            }
        }

    }

    InitBindings();
    setVideoIFrame();
    collapseAllFilterGroups();
});
