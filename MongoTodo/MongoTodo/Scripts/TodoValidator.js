
$.validator.addMethod(
    "Title",
    function (value, element, params) {
        var MinLength = params[0];
        var MaxLength = params[1];

        var failed = hasValidationError(params[0], params[1]);

        if (failed) return false;
        return true;
    });


$.validator.unobtrusive.adapters.add(
    "Title",
    ["minlength", "maxlength"],
    function (options) {
        var params = new Array(
            options.params.MinLength,
            options.params.MaxLength);
        var msg = options.message;

        options.rules["Titel"] = params;
        options.message["Titel"] = msg;
    }
    );