$.validator.setDefaults({
    errorPlacement: function (error, element) {
        //debugger;
        return true;
    },
    highlight: function (element, errorClass, validClass) {
        //debugger;
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
        //debugger;
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
        //debugger;
        $.each(this.successList, function (index, value) {
            $(value).popover('hide');
        });

        $.each(errorList, function (index, value) {
            var pop = $(value.element).popover({
                trigger: 'manual',
                content: value.message,
                template: '<div class="popover"><div class="arrow"></div><div class="popover-inner"><div class="popover-content"><p></p></div></div></div>'
            });

            pop.data('bs.popover').options.content = value.message;

            $(value.element).popover('show');

        });

        //debugger;
        this.defaultShowErrors();
    }
});
