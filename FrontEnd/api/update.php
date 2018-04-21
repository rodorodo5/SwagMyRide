<?php
    include_once '../connection.php';
    class User {
        private $db;
        private $connection;
        
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }
        public function update($title,$smalldescription,$description,$id,$imgname)
        {
            $image = "http://tecnami.com/medicis/uploads/" . trim($imgname);

            if (strlen($imgname) > 3) {
                $sql = "UPDATE posts SET title = '$title', smalldescription = '$smalldescription', description = '$description' , imgname = '$image' WHERE id = '$id'";
                $result = mysqli_query($this->connection, $sql);

                $sql = "SELECT * FROM posts WHERE id = '$id'"; 
                $result = mysqli_query($this->connection, $sql);
                $data = $result->fetch_assoc();
                echo json_encode($data);
            }
            else{
                $sql = "UPDATE posts SET title = '$title', smalldescription = '$smalldescription', description = '$description' WHERE id = '$id'";
                $result = mysqli_query($this->connection, $sql);

                $sql = "SELECT * FROM posts WHERE id = '$id'";

                $result = mysqli_query($this->connection, $sql);

                $data = $result->fetch_assoc();
                echo json_encode($data);
            }     
        }
    }

    $user = new User();
    $post = json_decode(file_get_contents("php://input"));
    $id  = $_GET["id"];
    $imgname = $post->imgname;
    $title = $post->title;
    $smalldescription = $post->smalldescription;
    $description = $post->description;
    $smalldescription = addslashes($smalldescription);
    $description = addslashes($description);
    $user-> update($title,$smalldescription,$description,$id,$imgname);
?>