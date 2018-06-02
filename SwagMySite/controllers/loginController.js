app.controller('loginController', function($scope, $http, $location, user) {


	$scope.login = function() {
		var email = $scope.email;
		var password = $scope.password;
		var uri = "http://swagmyapi.azurewebsites.net/api/userdata/" + email +
		"/" + password;

		$http.get(uri).then(function(callback){
			if (callback.data === 'Error') {
				alert("errro")
			}
			else{
				var rep =  JSON.parse(callback.data);
				console.log(rep);
				if(rep.status == 'loggedin') {
					user.saveData(rep);
					$location.path('/panel');
				}
			}
		});

	};

	

	
	$scope.goView = function(view){
		$location.path(view);
	}

});