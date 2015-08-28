module app.example {
    'use strict';

    interface IExampleViewModel {
        examples: app.domain.IExample[];
    }

    class ExampleController implements IExampleViewModel {

        static $inject: string[] = ['app.services.repositories.ExampleRepository'];
        constructor(private exampleRepository: app.services.repositories.IExampleRepository,
            public examples: app.domain.IExample[]) {
            var vm = this;

            var example = new app.domain.Example("Shelly");

            exampleRepository.save(example).$promise.then((response) => {
                var t = response;
            });

            exampleRepository.query().$promise.then((data: app.domain.IExample[]) => {
                vm.examples = data;
            });
        }
    }

    angular
        .module('app.example')
        .controller('app.example.ExampleController',
            ExampleController);
} 