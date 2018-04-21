<?php 

    include_once '../connection.php';

    class User {
        private $db;
        private $connection;
        
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }
        public function get_recent()
        {
            $sql = "SELECT * FROM (
                SELECT * FROM posts ORDER BY id DESC LIMIT 3
            ) posts
            ORDER BY id ASC";

            $result = mysqli_query($this->connection, $sql);
            while($row = $result->fetch_assoc()){
                 $json[] = $row;
            }
            $data['data'] = $json;
            echo json_encode($data);
            mysqli_close($this -> connection);
        }

    }

    $user = new User();
    $user-> get_recent();
	
?>

