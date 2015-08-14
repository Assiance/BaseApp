((): void => {
    'use strict';

    angular.module('app', [
        'app.core',
        'app.layout',
        'app.services',
        'app.widgets',
        'app.blocks',
    /*
     *  Feature Areas
     */
        'app.dashboard',
        'app.sitesettings',
        'app.login'
    ]);
})(); 