var app;
(function (app) {
    var domain;
    (function (domain) {
        'use strict';
        var Example = (function () {
            function Example(exampleId, title) {
                this.exampleId = exampleId;
                this.title = title;
            }
            return Example;
        })();
        domain.Example = Example;
    })(domain = app.domain || (app.domain = {}));
})(app || (app = {}));
//# sourceMappingURL=example.model.js.map