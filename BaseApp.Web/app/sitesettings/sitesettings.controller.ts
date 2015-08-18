 module app.sitesettings {
     'use strict';

     interface ISiteSettingsViewModel {
         title: string;
         description: string;
         themeNames: string[];
         themeName: string;
         save(): void;
     }

     class SiteSettingsController implements ISiteSettingsViewModel {
         title: string;
         description: string;
         themeNames: string[];
         themeName: string;

         constructor() { }

         save(): void { }
     }

     angular
         .module('app.sitesettings')
         .controller('app.sitesettings.SiteSettingsController',
             SiteSettingsController);
 }