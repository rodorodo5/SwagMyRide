<?php
    include_once '../connection.php';
    class master {
        private $db;
        private $connection;
        function __construct() {
            $this -> db = new DB_Connection();
            $this -> connection = $this->db->getConnection();
        }
        public function user_login($email,$password)
        {   
            $password = md5($password);
            $sql = "SELECT Email FROM Usuario WHERE Email='$email' AND Password='$password'";
            $result = mysqli_query($this->connection, $sql);
            if(mysqli_num_rows($result)>0){
                $token = $password;
                $sql = "UPDATE Usuario SET Token='$token' WHERE Email='$email' AND Password='$password'";
                $inserted = mysqli_query($this->connection, $sql);
                while($row = $result->fetch_assoc()){
                     $email = $row;
                }
                $array = array($email, $token);
                echo json_encode($array);
                mysqli_close($this -> connection);
            }
            else{
                echo json_encode("Wrong Credentials");
                mysqli_close($this->connection);
            }   
        }

        public function logout($token)
        {
            $sql = "UPDATE Usuario SET Token='Logged Out' WHERE Token='$token'";
            $result = mysqli_query($this->connection, $sql);
        }

        public function signup($email,$password,$nombre,$apellido,$isAdmin)
        {
            $token = 'Logged Out';
            $password = md5($password);
            $sql = "INSERT INTO Usuario (Email,Password,Nombre,Apellido,isAdmin,Token) VALUES ('$email', '$password','$nombre','$apellido','$isAdmin','$token')";
            $result = mysqli_query($this->connection, $sql);
            echo json_encode($username);
        }

        public function delete_factura($id)
        {
            $sql = "DELETE FROM Factura WHERE FacturaId = '$id'";
            $result = mysqli_query($this->connection, $sql);
            echo json_encode([$id]);
        }
        public function delete_user($id)
        {
            $sql = "DELETE FROM Usuario WHERE UserID = '$id'";
            $result = mysqli_query($this->connection, $sql);
            echo json_encode([$id]);
        }
        public function delete_report($id)
        {
            $sql = "DELETE FROM Report WHERE ReporteId = '$id'";
            $result = mysqli_query($this->connection, $sql);
            echo json_encode([$id]);
        }

        public function delete_cat($id,$table)
        {
            $sql = "DELETE FROM ".$table." WHERE ".$table."Id = '$id'";
            $result = mysqli_query($this->connection, $sql);
            echo json_encode([$id]);
        }


        public function check_token($token)
        {
            $sql = "SELECT Nombre FROM Usuario WHERE Token='$token'";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                 while($row = $result->fetch_assoc()){
                     $name = $row;
                }
                $array = array($name, $token);
                echo json_encode($array);
                mysqli_close($this->connection);
            } else {
                echo "unauthorized";
                mysqli_close($this->connection);
            }
        }

        public function bring_user($token)
        {
            $sql = "SELECT Email FROM Usuario WHERE Token='$token'";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                while($row = $result->fetch_assoc()){
                     $json[] = $row;
                }
                $data['data'] = $json;
                echo json_encode($data);
                mysqli_close($this->connection);
            } else {
                echo "No match";
                mysqli_close($this->connection);
            }
        }
        public function fill_restaurant()
        {
           $sql = "SELECT RestaurantName,RestaurantId  FROM Restaurant ORDER BY RestaurantId ASC";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                while($row = $result->fetch_assoc()){
                     $json[] = $row;
                }
                $data = $json;
                echo json_encode($data);
                mysqli_close($this->connection);
            } else {
                echo "No match";
                mysqli_close($this->connection);
            }
        }
        public function fill_unit()
        {
           $sql = "SELECT UnitName,UnitId  FROM Unit ORDER BY UnitId ASC";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                while($row = $result->fetch_assoc()){
                     $json[] = $row;
                }
                $data = $json;
                echo json_encode($data);
                mysqli_close($this->connection);
            } else {
                echo "No match";
                mysqli_close($this->connection);
            }
        }
        public function fill_supplier()
        {
           $sql = "SELECT SupplierName,SupplierId  FROM Supplier ORDER BY SupplierId ASC";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                while($row = $result->fetch_assoc()){
                     $json[] = $row;
                }
                $data = $json;
                echo json_encode($data);
                mysqli_close($this->connection);
            } else {
                echo "No match";
                mysqli_close($this->connection);
            }
        }
    

        public function fill_categoria()
        {
            $sql = "SELECT CategoryName,CategoryId FROM Category ORDER BY CategoryId ASC";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                while($row = $result->fetch_assoc()){
                     $json[] = $row;
                }
                $data = $json;
                echo json_encode($data);
                mysqli_close($this->connection);
            } else {
                echo "No match";
                mysqli_close($this->connection);
            }
        }

        public function fill_product()
        {
            $sql = "SELECT ProductName,ProductId FROM Product ORDER BY ProductId ASC";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                while($row = $result->fetch_assoc()){
                     $json[] = $row;
                }
                $data = $json;
                echo json_encode($data);
                mysqli_close($this->connection);
            } else {
                echo "No match";
                mysqli_close($this->connection);
            }
        }
        public function fill_users()
        {
            $sql = "SELECT Email,Nombre,Apellido,IsAdmin,UserID FROM Usuario ORDER BY UserID ASC";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                while($row = $result->fetch_assoc()){
                     $json[] = $row;
                }
                $data = $json;
                echo json_encode($data);
                mysqli_close($this->connection);
            } 
            else {
                echo "No match";
                mysqli_close($this->connection);
            }
        }
          public function fill_reports()
        {
            $sql = "SELECT Nombre,ReporteId FROM Report ORDER BY ReporteId ASC";
            $result = mysqli_query($this->connection, $sql);
            if (mysqli_num_rows($result)>0){
                while($row = $result->fetch_assoc()){
                     $json[] = $row;
                }
                $data = $json;
                echo json_encode($data);
                mysqli_close($this->connection);
            } 
            else {
                echo "Error";
                mysqli_close($this->connection);
            }
        }


        public function insertFactura($num_factura,$producto,$proveedor,$categoria,$cantidad,$unidad,$tipodepago,$tipodecambio,$restaurante,$pagada,$fechadepago,$moneda,$iva,$iva_retenido,$ieps,$isr_retenido,$timbrada,$deducible,$dias_credito,$abono,$fechalimite,$precio,$subtotal,$nota,$fechadelanota,$restante,$fechaderegistro){

            $sql = "INSERT INTO Factura (NoFactura,Proveedor,Producto,Cantidad,Unidad,PrecioUnitario,Subtotal,Moneda,TipoDeCambio,IVA,IEPS,IVARetenido,ISRRetenido,Abono,Timbrada,Pagada,TipoPago,Deducible,Restaurante,Categoria,FechaPago,Nota,Fecha,DiasCredito,FechaLimite,Restante,FechaHoy) VALUES ('".$num_factura."','".$proveedor."','".$producto."','".$cantidad."','".$unidad."','".$precio."','".$subtotal."','".$moneda."','".$tipodecambio."','".$iva."','".$ieps."','".$iva_retenido."','".$isr_retenido."','".$abono."','".$timbrada."','".$pagada."','".$tipodepago."','".$deducible."','".$restaurante."','".$categoria."','".$fechadepago."','".$nota."','".$fechadelanota."','".$dias_credito."','".$fechalimite."','".$restante."','".$fechaderegistro."')";

            $result = mysqli_query($this->connection, $sql);
            if($result){
                echo "Success";
            }
            else{
                echo "Error";
            }

        }
         public function addReporte($fecha_inicio,$fecha_final,$tpcambio,$efectivo_monto_mn,$efectivo_iva_mn,$efectivo_monto_usd, $efectivo_iva_usd,$debito_monto_mn,$debito_iva_mn,$debito_monto_usd,$debito_iva_usd,$divisas_monto_mn, $divisas_iva_mn,$divisas_monto_usd, $divisas_iva_usd){
            $tdd = date('Y'); 
            $nombre = $tdd . " | " . date("M j", strtotime($fecha_inicio)) . " -- " . date("M j", strtotime($fecha_final));
       
            $sql = "INSERT INTO Report (Nombre,FechaInicio,FechaFin,TipoDeCambio,EfectivoPesos,EfectivoPesosIVA,EfectivoUSD,EfectivoUSDIVA,TarjetaPesos,TarjetaPesosIVA,TarjetaUSD,TarjetaUSDIVA,CompraDivPesos,CompraDivPesosIVA,CompraDivUSD,CompraDivUSDIVA) VALUES ('".$nombre."','".$fecha_inicio."','".$fecha_final."','".$tpcambio."','".$efectivo_monto_mn."','".$efectivo_iva_mn."','".$efectivo_monto_usd."','".$efectivo_iva_usd."','".$debito_monto_mn."','".$debito_iva_mn."','".$debito_monto_usd."','".$debito_iva_usd."','".$divisas_monto_mn."','".$divisas_iva_mn."','".$divisas_monto_usd."','".$divisas_iva_usd."')";

            $result = mysqli_query($this->connection, $sql);
            if($result){
                echo "Success";
            }
            else{
                echo "Error";
            }
        }
        public function createuser($Email,$password,$nombre,$apellido,$isadmin){
            if ($isadmin == "Si") {
                $isadmin = 1;
            }
            else{
                $isadmin = 0;
            }

            $sql = "INSERT INTO Usuario (Email,Password,Nombre,Apellido,IsAdmin) VALUES ('".$Email."','".$password."','".$nombre."','".$apellido."','".$isadmin."')";
            $result = mysqli_query($this->connection, $sql);
            if($result){
                $sql = "SELECT Email,Nombre,Apellido,IsAdmin,UserID FROM Usuario ORDER BY UserID ASC";
                $result = mysqli_query($this->connection, $sql);
                if (mysqli_num_rows($result)>0){
                    while($row = $result->fetch_assoc()){
                         $json[] = $row;
                    }
                    $data = $json;
                    echo json_encode($data);
                    mysqli_close($this->connection);
                } 
            }else{
                echo "Error";
            }
        }
        public function insert_database($text_insert,$table)
        {   
            $sql = "INSERT INTO ".$table." (".$table."Name) VALUES ('$text_insert')";
            $result = mysqli_query($this->connection, $sql);
            if($result){
                $sql2 = "SELECT ".$table."Name , ".$table."Id FROM ".$table." ORDER BY ".$table."Id ASC";
                $res = mysqli_query($this->connection, $sql2);
                if (mysqli_num_rows($res)>0){
                    while($row2 = $res->fetch_assoc()){
                         $json2[] = $row2;
                    }
                    $data2 = $json2;
                    echo json_encode($data2);
                    mysqli_close($this->connection);
                }
            }
            else{
                echo "Error";
            }
        }

    }
?>