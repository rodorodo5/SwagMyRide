<?php

    include_once '../connection.php';

    class User {
        private $db;
        private $connection;
        
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }
        public function add_post($title,$smalldescription,$description,$isDraft,$imgname)
        {
            $created = date('Y-m-d H:i:s'); 
            $image = "http://tecnami.com/medicis/uploads/" . trim($imgname);
             $sql = "INSERT INTO posts (created_at,title,smalldescription,description,isDraft,imgname) VALUES ('".$created."','".$title."','".$smalldescription."','".$description."','".$isDraft."','".$image."')";
            $result = mysqli_query($this->connection, $sql);
            if ($result) {
                $json = "success";
                $data['data'] = $json;
            }
        }
    }

    $user = new User();
    $data = json_decode(file_get_contents("php://input"));   

    $title = $data->title;
    $smalldescription = $data->smalldescription;
    $description = $data->description;
    $isDraft = $data->isDraft;
    $imgname = $data->imgname;
    $smalldescription = addslashes($smalldescription);
    $description = addslashes($description);
  
    $user-> add_post($title,$smalldescription,$description,$isDraft,$imgname);
  
?>




