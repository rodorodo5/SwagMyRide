var app = angular.module('main', ['ngRoute','ngSanitize','angularUtils.directives.dirPagination','colorpicker']);

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
	.when('/register', {
		templateUrl: 'views/register.html',
		controller: 'registerController'
	})
	.when('/carrito', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/carrito.html',
		controller: 'tiendaController'
	})
	.when('/historial', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/historial.html',
		controller: 'tiendaController'
	})
	.when('/edit', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/edit.html',
		controller: 'editController'
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
	.when('/check_submarca_car', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/check_submarca_car.html',
		controller: 'WizdardCarController'
	})
	.when('/check_marca_car', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/check_marca_car.html',
		controller: 'WizdardCarController'
	})
	.when('/tipo_select', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/tipo_select.html',
		controller: 'WizdardCarController'
	})
	.when('/crear_car', {
		resolve: {
			check: function($location, user) {
				if(!user.isUserLoggedIn()) {
					$location.path('/login');
				}
			},
		},
		templateUrl: 'views/crear_car.html',
		controller: 'createController'
	})




	
	.otherwise({
		template: 'Pagina no encontrada bobo'
	});
});


