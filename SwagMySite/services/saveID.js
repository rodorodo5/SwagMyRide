app.service('vechicleSaver', function() {

	var vId; // VehicleTypeId 1 avion 2 agua 3 tierra
	var vMarca; //VehicleBrandID
	var vSubMarca; // VehicleModelId
	var vCombustible; //vehiclecombuistible
	var vYear; //vehicleyear
	var vNameModel; //vehicle model name string
	var vNameBrand; //vehicle brand name string
	var EditVID; // vehicleID by user
	


	// ------ sets ------ //
	this.setVehicleID = function(param) {
		vId = param;
	};

	this.setVehicleMarca = function(param) {
		vMarca = param;
	};
	
	this.setVehicleSubMarca = function(param) {
		vSubMarca = param;
	};
	this.setVehicleCombustible = function(param) {
		vCombustible = param;
	};
	this.setVehicleYear = function(param) {
		vYear = param;
	};

	this.setVehicleNameModel = function(param) {
		vNameModel = param;
	};
	this.setVehicleNameBrand = function(param) {
		vNameBrand = param;
	};
	this.setEditVID = function(param) {
		EditVID = param;
	};
	
	



	// ------ GETS ------ //


	this.getVID = function() { //regresa vehicle ID
		return vId;
	};
	this.getVMarca = function() { //regresa Brand ID
		return vMarca;
	};

	this.getVSubMarca = function() { //regresa Subbrand ID
		return vSubMarca;
	};
	this.getVCombustible = function() { //regresa Combustible ID
		return vCombustible;
	};
	this.getVYear = function() { //regresa Combustible ID
		return vYear;
	};
	this.getVNameModel = function() { //regresa Combustible ID
		return vNameModel;
	};
	this.getVNamebrand = function() { //regresa Combustible ID
		return vNameBrand;
	};

	this.getEditVID = function() { //regresa edit vehicle ID
		return EditVID;
	};

	// ------ cleans ------ //
	this.clearData = function() { //if user cancels the wizard.
		vId = "";
		vMarca = "";
		vSubMarca = "";
		vCombustible; //vehiclecombuistible
		vYear; //vehicleyear
	};
	

});

