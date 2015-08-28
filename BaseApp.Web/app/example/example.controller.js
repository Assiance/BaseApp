var app;
(function (app) {
    var example;
    (function (example_1) {
        'use strict';
        var ExampleController = (function () {
            function ExampleController(exampleRepository, examples) {
                this.exampleRepository = exampleRepository;
                this.examples = examples;
                var vm = this;
                var example = new app.domain.Example("Shelly");
                exampleRepository.save(example).$promise.then(function (response) {
                    var t = response;
                });
                exampleRepository.query().$promise.then(function (data) {
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