app.controller('editController', function($scope, $http, $location, user,vechicleSaver) {

	$scope.goView = function(view){
		$location.path(view);
	}
	$scope.userVehicles = [];
	$scope.gVType = '';
	$scope.gVID = '';
	//infos
	
	

	$scope.editar_vehicle_car = function(combustibleId,vechileBrandName,vehicleModelName,vehicleYear,
		vehicleModelId,editVType,VID,VModelID,brakeId,motorId,bodyWorkId,electicSystemId,suspensionId,
		wheelId,tiresId,color){
		//values for requests
		vechicleSaver.setVehicleID(editVType); //tipo de vehiculo 1,2,3
		vechicleSaver.setVehicleSubMarca(vehicleModelId); //modelo -- submarca 
		vechicleSaver.setVehicleMarca(VModelID); // ModelId
		vechicleSaver.setVehicleYear(vehicleYear);
		vechicleSaver.setVehicleNameModel(vehicleModelName);
		vechicleSaver.setVehicleNameBrand(vechileBrandName);
		vechicleSaver.setVehicleCombustible(combustibleId);
		vechicleSaver.setEditVID(VID); // ID unico del Vehiculo.
		//globals for showing
		$scope.gVType = vechicleSaver.getVID(); 
		$scope.gVID = vechicleSaver.getVNamebrand();
		//Selected Brake
		$scope.car.brake = brakeId;
		$scope.car.motor = motorId;
		$scope.car.bodywork = bodyWorkId;
		$scope.car.electric = electicSystemId;
		$scope.car.suspension = suspensionId;
		$scope.car.llantas = wheelId;
		$scope.car.rines = tiresId;
		$scope.car.color = color;
	}

	$scope.editar_vehicle_bote = function(combustibleId,vechileBrandName,vehicleModelName,vehicleYear,
		vehicleModelId,editVType,VID,VModelID,motorId,bodyWorkId,electicSystemId,boatBladesId,
		boatBladesCount,color){
		//values for requests
		vechicleSaver.setVehicleID(editVType); //tipo de vehiculo 1,2,3
		vechicleSaver.setVehicleSubMarca(vehicleModelId); //modelo -- submarca 
		vechicleSaver.setVehicleMarca(VModelID); // ModelId
		vechicleSaver.setVehicleYear(vehicleYear);
		vechicleSaver.setVehicleNameModel(vehicleModelName);
		vechicleSaver.setVehicleNameBrand(vechileBrandName);
		vechicleSaver.setVehicleCombustible(combustibleId);
		vechicleSaver.setEditVID(VID); // ID unico del Vehiculo.



		$scope.gVType = vechicleSaver.getVID(); 
		$scope.gVID = vechicleSaver.getVNamebrand();

		//Selected Brake
		$scope.car.motor = motorId;
		$scope.car.bodywork = bodyWorkId;
		$scope.car.electric = electicSystemId;
		$scope.car.blades = boatBladesId;
		$scope.car.numblades = boatBladesCount;
		$scope.car.color = color;
	}

	$scope.editar_vehicle_plane = function(combustibleId,vechileBrandName,vehicleModelName,vehicleYear,
		vehicleModelId,editVType,VID,VModelID,brakeId,motorId,bodyWorkId,electicSystemId,
		suspensionId,wheelId,turbinesId,turbinesCount,color){
		//values for requests
		vechicleSaver.setVehicleID(editVType); //tipo de vehiculo 1,2,3
		vechicleSaver.setVehicleSubMarca(vehicleModelId); //modelo -- submarca 
		vechicleSaver.setVehicleMarca(VModelID); // ModelId
		vechicleSaver.setVehicleYear(vehicleYear);
		vechicleSaver.setVehicleNameModel(vehicleModelName);
		vechicleSaver.setVehicleNameBrand(vechileBrandName);
		vechicleSaver.setVehicleCombustible(combustibleId);
		vechicleSaver.setEditVID(VID); // ID unico del Vehiculo.


		$scope.gVType = vechicleSaver.getVID(); 
		$scope.gVID = vechicleSaver.getVNamebrand();

		//Selected Brake
		$scope.car.brake = brakeId;
		$scope.car.motor = motorId;
		$scope.car.bodywork = bodyWorkId;
		$scope.car.electric = electicSystemId;
		$scope.car.suspension = suspensionId;
		$scope.car.llantas = wheelId;
		$scope.car.turbinas = turbinesId;
		$scope.car.numturbinas = turbinesCount;
		$scope.car.color = color;
	}

	$scope.fill_uservehicles = function () {
		var userid = user.getID();
		var uri = "http://swagmyapi.azurewebsites.net/api/data/vehicle/user/" + userid;
		$http.get(uri).then(function(callback){
			console.log(callback);
			$scope.userVehicles = callback.data;
		});
	};

	

	// ------------------- START Brakes --------------------

	$scope.fillBreaks = [];
	$scope.breaksClicked = false;


	$scope.fill_breaks = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.breaksClicked) {
			$scope.breaksClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/break/component/'+ vehicleModelId).then(function(callback){
				console.log("Breaks: ", callback);
				$scope.fillBreaks = callback.data;
				$scope.getBrakeInfo($scope.car.brake);
			});
		}
	};

	$scope.brakeInfo = null;
	$scope.getBrakeInfo = function(brakeId) {
		$scope.brakeInfo = $scope.fillBreaks.find(function(item){return item.brakeId == brakeId});
	}

	// ------------------- START Motor --------------------

	$scope.fillMotor = [];
	$scope.motorClicked = false;

	$scope.fill_motor = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.motorClicked) {
			$scope.motorClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/motor/component/'+ vehicleModelId).then(function(callback){
				console.log("Motor: " , callback);
				$scope.fillMotor = callback.data;
				$scope.getMotorInfo($scope.car.motor);
			});
		}
	};

	 $scope.motorInfo = null;
	  $scope.getMotorInfo = function(motorId) {
	    $scope.motorInfo = $scope.fillMotor.find(function(item){return item.motorId == motorId});
	    vechicleSaver.setVehicleCombustible($scope.motorInfo.combustibleId);
	}

	// ------------------- START Bodyw --------------------

	$scope.fillBodyw = [];
	$scope.bodywClicked = false;

	$scope.fill_bodywork = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.bodywClicked) {
			$scope.bodywClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/bodywork/component/'+ vehicleModelId).then(function(callback){
				console.log("BodyWork: " ,callback);
				$scope.fillBodyw = callback.data;
				$scope.getBodywInfo($scope.car.bodywork);
			});
		}
	};

	 $scope.bodyWinfo = null;
	  $scope.getBodywInfo = function(bodyWorkId) {
	    $scope.bodyWinfo = $scope.fillBodyw.find(function(item){return item.bodyWorkId == bodyWorkId});
	}

	// ------------------- START Electric --------------------

	$scope.fillElectric = [];
	$scope.ElectricClicked = false;

	$scope.fill_electric = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.ElectricClicked) {
			$scope.ElectricClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/electricsystem/component/'+ vehicleModelId).then(function(callback){
				console.log("Electric Sys: " ,callback);
				$scope.fillElectric = callback.data;
				$scope.getElectricInfo($scope.car.electric);
			});
		}
	};

	 $scope.ElectricInfo = null;
	  $scope.getElectricInfo = function(electicSystemId) {
	    $scope.ElectricInfo = $scope.fillElectric.find(function(item){return item.electicSystemId == electicSystemId});
	}

	// ------------------- START Suspension --------------------

	$scope.fillSuspension = [];
	$scope.SuspensionClicked = false;

	$scope.fill_suspension = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.SuspensionClicked) {
			$scope.SuspensionClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/suspension/component/'+ vehicleModelId).then(function(callback){
				console.log("Suspension: " ,callback);
				$scope.fillSuspension = callback.data;
				$scope.getSuspensionInfo($scope.car.suspension);
			});
		}
	};

	 $scope.SuspensionInfo = null;
	  $scope.getSuspensionInfo = function(suspensionId) {
	    $scope.SuspensionInfo = $scope.fillSuspension.find(function(item){return item.suspensionId == suspensionId});
	}

	// ------------------- START llantas --------------------

	$scope.fillLlantas = [];
	$scope.LlantasClicked = false;

	$scope.fill_llantas = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.LlantasClicked) {
			$scope.LlantasClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/wheel/component/'+ vehicleModelId).then(function(callback){
				console.log("Llantas: " ,callback);
				$scope.fillLlantas = callback.data;
				$scope.getLlantasInfo($scope.car.llantas);
			});
		}
	};

	 $scope.LlantasInfo = null;
	  $scope.getLlantasInfo = function(wheelId) {
	    $scope.LlantasInfo = $scope.fillLlantas.find(function(item){return item.wheelId == wheelId});
	}

	// ------------------- START Rines --------------------

	$scope.fillRines = [];
	$scope.RinesClicked = false;

	$scope.fill_rines = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.RinesClicked) {
			$scope.RinesClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/tires/component/'+ vehicleModelId).then(function(callback){
				console.log("Rines: " ,callback);
				$scope.fillRines = callback.data;
				$scope.getRinesInfo($scope.car.rines);
			});
		}
	};

	 $scope.RinesInfo = null;
	  $scope.getRinesInfo = function(tiresId) {
	    $scope.RinesInfo = $scope.fillRines.find(function(item){return item.tiresId == tiresId});
	}

	// ------------------- START turbinas --------------------

	$scope.fillTurbinas = [];
	$scope.turbinaClicked = false;


	$scope.fill_turbinas = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.turbinaClicked) {
			$scope.turbinaClicked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/turbines/component/'+ vehicleModelId).then(function(callback){
				console.log("Turbinas: ", callback);
				$scope.fillTurbinas = callback.data;
				$scope.getTurbinaInfo($scope.car.turbinas);
			});
		}
	};

	 $scope.TurbinaInfo = null;
	  $scope.getTurbinaInfo = function(turbinesId) {
	    $scope.TurbinaInfo = $scope.fillTurbinas.find(function(item){return item.turbinesId == turbinesId});
	  }


	// ------------------- START blades --------------------

	$scope.fillBlades = [];
	$scope.bladesClked = false;


	$scope.fill_blades = function(){
		var vehicleModelId = vechicleSaver.getVSubMarca();
		if (!$scope.bladesClked) {
			$scope.bladesClked = true;
			$http.get('http://swagmyapi.azurewebsites.net/api/data/boatblades/component/'+ vehicleModelId).then(function(callback){
				console.log("Blades: ", callback);
				$scope.fillBlades = callback.data;
				$scope.getbladesInfo($scope.car.blades);
			});
		}
	};

	 $scope.bladesInfo = null;
	  $scope.getbladesInfo = function(boatBladesId) {
	    $scope.bladesInfo = $scope.fillBlades.find(function(item){return item.boatBladesId == boatBladesId});
	  }




	// ------------------- START InsertCar --------------------

	$scope.insertCar = function(){

		var VehicleTypeId = vechicleSaver.getVID();
		var BrandId = vechicleSaver.getVMarca();
		var ModelId = vechicleSaver.getVSubMarca();
		var combustibleId = vechicleSaver.getVCombustible();
		var vehicleYear = vechicleSaver.getVYear();
		var UserId = user.getID();
		var vehicleBaseId = vechicleSaver.getEditVID();

		var ModelName = vechicleSaver.getVNameModel();
		var BrandName = vechicleSaver.getVNamebrand();


		var data = {
			TiresId : $scope.car.rines,
			BrakeId: $scope.car.brake,
			SuspensionId: $scope.car.suspension,
			MotorId: $scope.car.motor,
			ProvideUser: parseInt(UserId),
			ProvideVehicleType: VehicleTypeId,
			Color: $scope.car.color,
			ProvideBodyWork: $scope.car.bodywork,
			ProvideElectrySystem: $scope.car.electric,
			ProvideCombustibleId: combustibleId,
			ProvideModelId : ModelId,
			ProvideVehicleYear : vehicleYear,
			ProvideVehicleBrandId: BrandId,
			WheelId: $scope.car.llantas,
			ProvideBrandName: BrandName,
			ProvideModelName: ModelName,
			VehicleBaseId : vehicleBaseId
		}

		console.log(data)
		
		$http.post('http://swagmyapi.azurewebsites.net/api/data/vehicle/updatevehicle/', data ).then(function(callback){
				console.log("Inser car: " ,callback);
				if (callback.data.isSuccessStatusCode == true) {
					alert("Vehiculo Actualizado")
					$scope.fill_uservehicles();
				}
				else {
					alert("Asegurate de seleccionar todos los campos.")
				}

		});
	}

		// ------------------- START InsertPlane --------------------

	$scope.insertPlane = function(){

		var VehicleTypeId = vechicleSaver.getVID();
		var BrandId = vechicleSaver.getVMarca();
		var ModelId = vechicleSaver.getVSubMarca();
		var combustibleId = vechicleSaver.getVCombustible();
		var vehicleYear = vechicleSaver.getVYear();
		var UserId = user.getID();
		var vehicleBaseId = vechicleSaver.getEditVID();
		var ModelName = vechicleSaver.getVNameModel();
		var BrandName = vechicleSaver.getVNamebrand();

		var data = {
			BrakeId: $scope.car.brake,
			SuspensionId: $scope.car.suspension,
			MotorId: $scope.car.motor,
			ProvideUser: parseInt(UserId),
			ProvideVehicleType: VehicleTypeId,
			Color: $scope.car.color,
			ProvideBodyWork: $scope.car.bodywork,
			ProvideElectrySystem: $scope.car.electric,
			ProvideCombustibleId: combustibleId,
			ProvideModelId : ModelId,
			ProvideVehicleYear : vehicleYear,
			ProvideVehicleBrandId: BrandId,
			WheelId: $scope.car.llantas,
			Turbines: $scope.car.turbinas,
			TurbinesCount: $scope.car.numturbinas,
			ProvideBrandName: BrandName,
			ProvideModelName: ModelName,
			VehicleBaseId: vehicleBaseId
		}

		console.log(data)
		
		$http.post('http://swagmyapi.azurewebsites.net/api/data/vehicle/updatevehicle/', data ).then(function(callback){
				console.log("Edit plane: " ,callback);
				if (callback.data.isSuccessStatusCode == true) {
					alert("Vehiculo Editado")
					$scope.fill_uservehicles();
				}
				else {
					alert("Asegurate de seleccionar todos los campos.")
				}

		});
	}

	$scope.insertBoat = function(){

		var VehicleTypeId = vechicleSaver.getVID();
		var BrandId = vechicleSaver.getVMarca(); //id
		var ModelId = vechicleSaver.getVSubMarca(); //id
		var combustibleId = vechicleSaver.getVCombustible();
		var vehicleYear = vechicleSaver.getVYear();
		var UserId = user.getID();
		var vehicleBaseId = vechicleSaver.getEditVID();
		var ModelName = vechicleSaver.getVNameModel();
		var BrandName = vechicleSaver.getVNamebrand();

		var data = {
			MotorId: $scope.car.motor,
			ProvideUser: parseInt(UserId),
			ProvideVehicleType: VehicleTypeId,
			Color: $scope.car.color,
			ProvideBodyWork: $scope.car.bodywork,
			ProvideElectrySystem: $scope.car.electric,
			ProvideCombustibleId: combustibleId,
			ProvideModelId : ModelId,
			ProvideVehicleYear : vehicleYear,
			ProvideVehicleBrandId: BrandId,
			BoatBladesId: $scope.car.blades,
			BoatBladesCount: $scope.car.numblades,
			ProvideBrandName: BrandName,
			ProvideModelName: ModelName,
			VehicleBaseId: vehicleBaseId
		}

		console.log(data)
		
		$http.post('http://swagmyapi.azurewebsites.net/api/data/vehicle/updatevehicle/', data ).then(function(callback){
				console.log("Edit boat: " ,callback);
				if (callback.data.isSuccessStatusCode == true) {
					alert("Bote actualizado")
					$scope.fill_uservehicles();
				}
				else {
					alert("Asegurate de seleccionar todos los campos.")
				}

		});
	}


	$scope.delete_vehicle = function(id){
		console.log(id, " id a eleminar")
		var result = confirm("Eliminar vehiculo con id: " + id + "?");
		if (result) {
			$http.post('http://swagmyapi.azurewebsites.net/api/data/deletevehicle/'+ id ).then(function(callback){
				console.log('delete: ',callback);
				if (callback.data.isSuccessStatusCode == true) {
					alert("Vehiculo eliminado")
					$scope.fill_uservehicles();
				}
				else {
					alert("Asegurate de enviar un id")
				}

			});
		}
	}


	$scope.save_order = function(ComponentType,ComponentId,Image,Name,Price,Description){
		var UserId = user.getID();
		var VehicleBaseId = vechicleSaver.getEditVID();
		var data = {
			ComponentType:ComponentType,
			ComponentId:ComponentId,
			Image:Image,
			Name:Name,
			Price:Price,
			Description:Description,
			UserProfileId: parseInt(UserId),
			UserVehicleBaseId: VehicleBaseId
		}

		console.log("Argregar a carrito: ", data)

		var result = confirm("Agregar a carrito el freno: " + Name + "?");
		if (result) {
			$http.post('http://swagmyapi.azurewebsites.net/api/data/saveorderlist', data).then(function(callback){
				console.log('Agregar a carrito callback : ',callback);
				if (callback.data.isSuccessStatusCode == true) {
					alert("Pieza agregada a carrito");
				}
				else {
					alert("Asegurate de enviar un id correcto")
				}

			});//request
		}



	}//save order



});
