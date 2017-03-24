namespace ConciergeApp {

    angular.module('ConciergeApp', ['ui.router', 'ngResource', 'ui.bootstrap', 'ngMap', 'google.places','ngtimeago']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        // Define routes
        $stateProvider
            .state('home', {
                url: '/',
                templateUrl: '/ngApp/views/home.html',
                controller: ConciergeApp.Controllers.HomeController,
                controllerAs: 'controller',
                onEnter: function ($rootScope) {
                    $rootScope.backgroundImage = ''
                }
            })
            .state('details', {
                url: '/details/:id',
                templateUrl: '/ngApp/views/details.html',
                controller: ConciergeApp.Controllers.DetailsController,
                controllerAs: 'controller',
                onEnter: function ($rootScope) {
                    $rootScope.backgroundImage = ''
                }
            })
            .state('searchResults', {
                url: '/searchResults',
                templateUrl: '/ngApp/views/searchResults.html',
                controller: ConciergeApp.Controllers.SearchResultsController,
                controllerAs: 'controller',
                onEnter: function ($rootScope) {
                    $rootScope.backgroundImage = ''
                }
            })
            .state('profile', {
                url: '/profile',
                templateUrl: '/ngApp/views/profile.html',
                controller: ConciergeApp.Controllers.ProfileController,
                controllerAs: 'controller',
                onEnter: function ($rootScope) {
                    $rootScope.backgroundImage = 'profile-image'
                }
            })
            .state('contactus', {
                url: '/contactuS',
                templateUrl: '/ngApp/views/contactus/html',
                controller: ConciergeApp.Controllers.HomeController,
                controllerAs: 'controller',
                onEnter: function ($rootScope) {
                    $rootScope.backgroundImage = ''
                }
            })
            .state('secret', {
                url: '/secret',
                templateUrl: '/ngApp/views/secret.html',
                controller: ConciergeApp.Controllers.SecretController,
                controllerAs: 'controller'
            })
            .state('login', {
                url: '/login',
                templateUrl: '/ngApp/views/login.html',
                controller: ConciergeApp.Controllers.LoginController,
                controllerAs: 'controller',
                onEnter: function ($rootScope) {
                    $rootScope.backgroundImage = ''
                }
            })
            .state('register', {
                url: '/register',
                templateUrl: '/ngApp/views/register.html',
                controller: ConciergeApp.Controllers.RegisterController,
                controllerAs: 'controller',
                onEnter: function ($rootScope) {
                    $rootScope.backgroundImage = ''
                }
            })
            .state('externalRegister', {
                url: '/externalRegister',
                templateUrl: '/ngApp/views/externalRegister.html',
                controller: ConciergeApp.Controllers.ExternalRegisterController,
                controllerAs: 'controller'
            })
            .state('about', {
                url: '/about',
                templateUrl: '/ngApp/views/about.html',
                controller: ConciergeApp.Controllers.AboutController,
                controllerAs: 'controller',
                onEnter: function ($rootScope) {
                    $rootScope.backgroundImage = ''
                }
            })
            .state('notFound', {
                url: '/notFound',
                templateUrl: '/ngApp/views/notFound.html'
            })



        // Handle request for non-existent route
        $urlRouterProvider.otherwise('/notFound');

        // Enable HTML5 navigation
        $locationProvider.html5Mode(true);
    });


    angular.module('ConciergeApp').factory('authInterceptor', (
        $q: ng.IQService,
        $window: ng.IWindowService,
        $location: ng.ILocationService
    ) =>
        ({
            request: function (config) {
                config.headers = config.headers || {};
                config.headers['X-Requested-With'] = 'XMLHttpRequest';
                return config;
            },
            responseError: function (rejection) {
                if (rejection.status === 401 || rejection.status === 403) {
                    $location.path('/login');
                }
                return $q.reject(rejection);
            }
        })
    );

    angular.module('ConciergeApp').config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptor');
    });



}
