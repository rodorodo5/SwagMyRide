app.controller('panelController', function($scope, $http, $location) {
	//Login Controller, Sessions and Cookies.

	$scope.goView = function(view){
		$location.path(view);
	}


});