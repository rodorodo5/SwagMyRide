<?php
	require_once 'config.php';
	class DB_Connection {
		private $connect;
		function __construct() {
			$this->connect = mysqli_connect(HOST, USER, PASS, DB)
			or die("Could not connect to the database");
		}
		public function getConnection()
		{
			return $this->connect;
		}
	}
 ?>