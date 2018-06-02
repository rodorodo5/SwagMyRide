app.controller('registerController', function($scope, $http, $location, user) {

	$scope.registeruser = function() {
		var genero = "";
		if ($scope.register.sexo == "Mujer") {
			genero = 'M'
		}
		else if ($scope.register.sexo == "Hombre") {
			genero = 'H'
		}
		else if ($scope.register.sexo == "Otro") {
			genero = 'O'
		}

		var data = {
			userName: $scope.register.name,
			userLastName: $scope.register.apellido,
			phone: $scope.register.telefono,
			gender : genero,
			country: $scope.register.pais,
			brithday:  $scope.register.bday,
			email:  $scope.register.email,
			password: $scope.register.pass
		}

		if ($scope.register.pass === $scope.register.confirm) {
			var uri = "http://swagmyapi.azurewebsites.net/api/userdata/add"
			$http.post(uri,data).then(function(callback){
				if (callback.data === "Success") {
					alert("Usuario creado");
					$location.path('/login');

				}else {
					alert("Error creando usuario");
				}
			});
		}
		else{
			alert("Contraseñas no coinciden");
		}

		
	}

	$scope.paisesFill = [];
	$scope.fill_pais = function (){
		var uri = "http://swagmyapi.azurewebsites.net/api/data/country";
		$http.get(uri).then(function(callback){
			$scope.paisesFill = callback.data;
		});
	}

	$scope.goView = function(view){
		$location.path(view);
	}

});