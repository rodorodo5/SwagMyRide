app.controller('tiendaController', function($scope, $http, $location, user) {

	$scope.goView = function(view){
		$location.path(view);
	}

	$scope.userCarrito = [];
	$scope.isempty = false;

	$scope.fill_carritos = function () {
		var userid = user.getID();
		var uri = "http://swagmyapi.azurewebsites.net/api/data/orderlist/" + userid;
		$http.get(uri).then(function(callback){
			console.log(callback);
			$scope.userCarrito = callback.data;
		});
	};


	$scope.delete_carritoitem = function(id,name){
		console.log(id, " id a eleminar")
		var result = confirm("Eliminar pieza: " + name + "?");
		if (result) {
			$http.post('http://swagmyapi.azurewebsites.net/api/data/deleteorderlist/'+ id ).then(function(callback){
				console.log('delete: ',callback);
				if (callback.data.isSuccessStatusCode == true) {
					alert("Parte eliminada del carrito")
					$scope.fill_carritos();
				}
				else {
					alert("Asegurate de enviar un id")
				}

			});
		}
	}


	$scope.comprar = function(orderListId){
		console.log(orderListId , " orderlist")
		var result = confirm("Comprar orden: " + orderListId + "?");
		if (result) {
			$http.post('http://swagmyapi.azurewebsites.net/api/data/updateorderlist/'+ orderListId + '/true' ).then(function(callback){
				console.log('Comprar: ',callback);
				if (callback.data.isSuccessStatusCode == true) {
					alert("Parte comprarda")
					$scope.fill_carritos();
				}
				else {
					alert("Asegurate de enviar un id")
				}

			});
		}
	}

});