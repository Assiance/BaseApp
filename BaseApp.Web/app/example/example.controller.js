var app;
(function (app) {
    var example;
    (function (example) {
        'use strict';
        var ExampleController = (function () {
            function ExampleController(dataAccessService, examples) {
                this.dataAccessService = dataAccessService;
                this.examples = examples;
                var vm = this;
                var exampleResource = dataAccessService.getExampleResource();
                exampleResource.query(function (data) {
                    vm.examples = data;
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