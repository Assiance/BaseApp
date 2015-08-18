﻿module app.example {
    'use strict';

    interface IExampleViewModel {
        examples: app.domain.IExample[];
    }

    class ExampleController implements IExampleViewModel {

        static $inject: string[] = ['dataAccessService'];
        constructor(private dataAccessService: app.services.IDataAccessService,
            public examples: app.domain.IExample[]) {
            var vm = this;

            var exampleResource = dataAccessService.getExampleResource();
            exampleResource.query((data: app.domain.IExample[]) => {
                vm.examples = data;
            });
        }
    }

    angular
        .module('app.example')
        .controller('app.example.ExampleController',
            ExampleController);
} 