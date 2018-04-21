app.controller('loginController', function($scope, $http, $location, user) {
	//Login Controller, Sessions and Cookies.
	$scope.login = function() {
		var username = $scope.username;
		var password = $scope.password;
		$http({
			url: 'api/server.php',
			method: 'POST',
			headers: {
				'Content-Type': 'application/x-www-form-urlencoded'
			},
			data: 'username='+username+'&password='+password
		}).then(function(response) {
			if(response.data.status == 'loggedin') {
				user.saveData(response.data);
				$location.path('/panel');
			} else {
				alert('invalid login');
			}
		})
	}

	$scope.goView = function(view){
		$location.path(view);
	}



});