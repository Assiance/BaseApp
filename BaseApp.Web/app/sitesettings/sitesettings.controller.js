var app;
(function (app) {
    var sitesettings;
    (function (sitesettings) {
        'use strict';
        var SiteSettingsController = (function () {
            function SiteSettingsController(title, description, themeNames, themeName) {
                this.title = title;
                this.description = description;
                this.themeNames = themeNames;
                this.themeName = themeName;
            }
            SiteSettingsController.prototype.save = function () { };
            SiteSettingsController.$inject = [''];
            return SiteSettingsController;
        })();
        angular
            .module('app.sitesettings')
            .controller('app.sitesettings.SiteSettingsController', SiteSettingsController);
    })(sitesettings = app.sitesettings || (app.sitesettings = {}));
})(app || (app = {}));
//# sourceMappingURL=siteSettings.controller.js.map