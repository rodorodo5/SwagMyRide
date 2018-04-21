var app = angular.module('main', ['ngRoute','angularUtils.directives.dirPagination','angular-growl','ngCkeditor','ngSanitize']);

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
	.when('/login', {
		templateUrl: 'views/login.html',
		controller: 'loginController'
	})
	.when('/home', {
		templateUrl: 'views/home.html',
		controller: 'homeController'
	})

	.when('/panel', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/home');
				}
			},
		},
		templateUrl: 'views/panel.html',
		controller: 'panelController'
	})
	.when('/create_vehicle', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/home');
				}
			},
		},
		templateUrl: 'views/create_vehicle.html',
		controller: 'createVehicleController'
	})
	
	.when('/modify/:id', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/home');
				}
			},
		},
		templateUrl: 'views/modify.html',
		controller: 'panelController'
	})
	.otherwise({
		template: 'Pagina no encontrada'
	});
});



app.filter('reverse', function() {
    return function(items) {
        return items.slice().reverse();
    };
});
