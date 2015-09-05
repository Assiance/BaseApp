var app;
(function (app) {
    var domain;
    (function (domain) {
        'use strict';
        var Example = (function () {
            function Example(FirstName) {
                this.FirstName = FirstName;
            }
            return Example;
        })();
        domain.Example = Example;
    })(domain = app.domain || (app.domain = {}));
})(app || (app = {}));
//# sourceMappingURL=example.model.js.map