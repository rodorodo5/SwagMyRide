<?php
	include_once '../connection.php';
    class User {
        private $db;
        private $connection;
        
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }

        public function get_data($page,$search)
        {
        	$num_rec_per_page = 3;
            $start_from = ($page-1) * $num_rec_per_page;
			if (!empty($search)){
				$sqlTotal = "SELECT * FROM posts 
					WHERE (title LIKE '%".$search."%' OR smalldescription LIKE '%".$search."%' OR description LIKE '%".$search."%')"; 
				$sql = "SELECT * FROM posts 
					WHERE (title LIKE '%".$search."%' OR smalldescription LIKE '%".$search."%' OR description LIKE '%".$search."%') 
					LIMIT $start_from, $num_rec_per_page"; 
			}else{
				$sqlTotal = "SELECT * FROM posts"; 
				$sql = "SELECT * FROM posts ORDER BY id DESC LIMIT $start_from, $num_rec_per_page"; 
			}

            $result = mysqli_query($this->connection, $sql);

            while($row = $result->fetch_assoc()){
			     $json[] = $row;
			}
			$data['data'] = $json;

			$result = mysqli_query($this->connection, $sqlTotal);
			$data['total'] = mysqli_num_rows($result);
			echo json_encode($data);

        }

    }

    $user = new User();

   	if(isset($_GET['page'])) {
   		$search = $_GET['search'];
		$page = $_GET['page'];
		$user-> get_data($page,$search);
	}
	else{
		$search = $_GET['search'];
		$page = 1;
		$user-> get_data($page,$search);
	
	}




?>