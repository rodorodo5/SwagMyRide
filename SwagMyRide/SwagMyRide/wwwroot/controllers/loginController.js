app.controller('loginController', function($scope, $http, $location, user) {

	$scope.login = function() {
		var email = $scope.email;
		var password = $scope.password;

		$http({
            url: 'api/userdata/{email}/{password}',
			method: 'POST',
			headers: {
				'Content-Type': 'application/x-www-form-urlencoded'
			},
			data: 'email='+ email+ '&password=' +password
        }).then(function (response) {
		    console.log(response.data);
			if(response.data === 'loggedin') {
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