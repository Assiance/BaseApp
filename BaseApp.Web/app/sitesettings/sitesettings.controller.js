var app;
(function (app) {
    var sitesettings;
    (function (sitesettings) {
        'use strict';
        var SiteSettingsController = (function () {
            function SiteSettingsController() {
            }
            SiteSettingsController.prototype.save = function () { };
            return SiteSettingsController;
        })();
        angular
            .module('app.sitesettings')
            .controller('app.sitesettings.SiteSettingsController', SiteSettingsController);
    })(sitesettings = app.sitesettings || (app.sitesettings = {}));
})(app || (app = {}));
//# sourceMappingURL=siteSettings.controller.js.map