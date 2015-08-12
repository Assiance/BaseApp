/* tslint:disable */
// Type definitions for Angular JS 1.3 (ngCookies module)
// Project: http://angularjs.org
// Definitions by: Diego Vilar <http://github.com/diegovilar>
// Definitions: https://github.com/borisyankov/DefinitelyTyped


/// <reference path="angular.d.ts" />

///////////////////////////////////////////////////////////////////////////////
// ngCookies module (angular-cookies.js)
///////////////////////////////////////////////////////////////////////////////
declare module ng.cookies {

    ///////////////////////////////////////////////////////////////////////////
    // CookieService
    // see http://docs.angularjs.org/api/ngCookies.$cookies
    ///////////////////////////////////////////////////////////////////////////
    interface ICookiesService {
        [index: string]: any;
    }

    ///////////////////////////////////////////////////////////////////////////
    // CookieStoreService
    // see http://docs.angularjs.org/api/ngCookies.$cookieStore
    ///////////////////////////////////////////////////////////////////////////
    interface ICookieStoreService {
        get(key: string): any;
        put(key: string, value: any): void;
        remove(key: string): void;
    }

}
