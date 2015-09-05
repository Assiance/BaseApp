var app;
(function (app) {
    var example;
    (function (example) {
        'use strict';
        var ExampleController = (function () {
            function ExampleController(exampleRepository, examples) {
                this.exampleRepository = exampleRepository;
                this.examples = examples;
                var vm = this;
                exampleRepository.context.query(function (data) {
                    vm.examples = data;
                });
            }
            ExampleController.$inject = ['app.services.repositories.ExampleRepository'];
            return ExampleController;
        })();
        angular
            .module('app.example')
            .controller('app.example.ExampleController', ExampleController);
    })(example = app.example || (app.example = {}));
})(app || (app = {}));
//# sourceMappingURL=example.controller.js.map