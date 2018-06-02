app.controller('homeController', function($scope, $http, $location,user) {
	//Login Controller, Sessions and Cookies.

	$scope.goView = function(view){
		$location.path(view);
	}
	$scope.user = user.getName();


});