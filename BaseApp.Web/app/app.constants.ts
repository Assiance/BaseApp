module app.constants {
    export interface IAppSettings {
        serverPath: string;
    }

    ((): void => {
        'use strict';

        var appSettings: IAppSettings = {
            serverPath: ''
        };

        angular
            .module('app')
            .constant('appSettings', appSettings);
    })();
}