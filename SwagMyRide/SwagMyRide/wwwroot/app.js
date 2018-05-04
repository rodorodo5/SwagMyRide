var app = angular.module('main', ['ngRoute','angularUtils.directives.dirPagination']);

app.config(function($routeProvider, $locationProvider) {
	$routeProvider.when('/', {
		templateUrl: 'views/home.html',
		controller: 'homeController'
	})
	.when('/logout', {
		resolve: {
			deadResolve: function($location, user) {
				user.clearData();
				$location.path('/');
			}
		}
	})
	.when('/home', {
		templateUrl: 'views/home.html',
		controller: 'homeController'
	})
	.when('/login', {
		templateUrl: 'views/login.html',
		controller: 'loginController'
	})
	.when('/panel', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/panel.html',
		controller: 'panelController'
	})
	.when('/crear', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/crear.html',
		controller: 'panelController'
	})

	.when('/editar', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/editar.html',
		controller: 'panelController'
	})
	
	.otherwise({
		template: 'Pagina no encontrada bobo'
	});
});


