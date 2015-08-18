var app;
(function (app) {
    var example;
    (function (example) {
        'use strict';
        var ExampleController = (function () {
            function ExampleController(dataAccessService, examples) {
                var _this = this;
                this.dataAccessService = dataAccessService;
                this.examples = examples;
                var exampleResource = dataAccessService.getExampleResource();
                exampleResource.query(function (data) {
                    _this.examples = data;
                });
            }
            ExampleController.$inject = ['dataAccessService'];
            return ExampleController;
        })();
        angular
            .module('app.example')
            .controller('app.example.ExampleController', ExampleController);
    })(example = app.example || (app.example = {}));
})(app || (app = {}));
//# sourceMappingURL=example.controller.js.map