$(document).ready(function () {


    $(function () {
        $('span.field-validation-valid, span.field-validation-error').each(function () {
            $(this).addClass('help-inline');
        });

        $('.validation-summary-errors').each(function () {
            $(this).addClass('alert');
            $(this).addClass('alert-error');
            $(this).addClass('alert-block');
        });

        $('form').submit(function () {
            if ($(this).valid()) {
                $(this).find('div.control-group').each(function () {
                    if ($(this).find('span.field-validation-error').length == 0) {
                        $(this).removeClass('error');
                    }
                });
            }
            else {
                $(this).find('div.control-group').each(function () {
                    if ($(this).find('span.field-validation-error').length > 0) {
                        $(this).addClass('error');
                    }
                });
                $('.validation-summary-errors').each(function () {
                    if ($(this).hasClass('alert-error') == false) {
                        $(this).addClass('alert');
                        $(this).addClass('alert-error');
                        $(this).addClass('alert-block');
                    }
                });
            }
        });

        $('form').each(function () {
            $(this).find('div.control-group').each(function () {
                if ($(this).find('span.field-validation-error').length > 0) {
                    $(this).addClass('error');
                }
            });
        });

        $("input[type='password'], input[type='text']").blur(function () {
            if ($(this).hasClass('input-validation-error') == true || $(this).closest(".control-group").find('span.field-validation-error').length > 0) {
                $(this).addClass('error');
                $(this).closest(".control-group").addClass("error");
            } else {
                $(this).removeClass('error');
                $(this).closest(".control-group").removeClass("error");
            }
        });
    });

    var page = function () {
        debugger;
        //Update that validator
        $.validator.setDefaults({
            //            highlight: function (element) {
            //                $(element).closest(".control-group").addClass("error");
            //            },
            //            unhighlight: function (element) {
            //                $(element).closest(".control-group").removeClass("error");
            //            },



            highlight: function (element, errorClass, validClass) {
                debugger;
                var $element;
                if (element.type === 'radio') {
                    $element = this.findByName(element.name);
                } else {
                    $element = $(element);
                }
                $element.addClass(errorClass).removeClass(validClass);
                $element.parents("div.control-group").addClass("error");
            },
            unhighlight: function (element, errorClass, validClass) {
                debugger;
                var $element;
                if (element.type === 'radio') {
                    $element = this.findByName(element.name);
                } else {
                    $element = $(element);
                }
                $element.removeClass(errorClass).addClass(validClass);
                $element.parents("div.control-group").removeClass("error");
            },
            showErrors: function (errorMap, errorList) {
                debugger;
                $.each(this.successList, function (index, value) {
                    $(value).popover('hide');
                });

                $.each(errorList, function (index, value) {
                    var pop = $(value.element).popover({
                        trigger: 'manual',
                        content: value.message,
                        title: 'Error'
                    });

                    pop.data('popover').options.content = value.message;

                    $(value.element).popover('show');

                });

                this.defaultShowErrors();
            }





        });
    } ();

    //    $(function () {
    //        $('form').each(function () {
    //            debugger;
    //            $(this).find('div.control-group').each(function () {
    //                if ($(this).find('.field-validation-error').length > 0) {
    //                    $(this).addClass('error');
    //                }
    //            });
    //        });
    //    });

});
