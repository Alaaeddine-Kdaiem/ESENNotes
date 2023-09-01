<?php

class Employes extends Controller {
  
  
    public function __construct(){
      if(!isLoggedIn()){
        redirect('users/login');
      }
      if( ($_SESSION['user_role_id'])!=2)
      {
        redirect('pages');
      }

      //import du models
      $this->employeModel = $this->model('Employe');
      $this->userModel = $this->model('User');

    }

    //affichage
    public function index(){

      //trouver tous les employes
      $employes = $this->employeModel->getemployes();
      $data = [
        'employes' => $employes,
      ];
      $this->view('employes/index',$data);
        

     }




      //ajout
  public function add(){
    if($_SERVER['REQUEST_METHOD'] == 'POST'){

      $data = [
        'nom'       =>trim($_POST["nom"]),
        'prenom'    =>trim($_POST["prenom"]),
        'email'     =>trim($_POST["email"]),
        'password'  =>trim($_POST["password"])
      ];

      if($this->userModel->addUserEmp($data)){
        $id = $this->userModel->getUserByEmail($data['email']); 
        if($this->employeModel->addEmploye($data,$id)){
          redirect('employes');
        }
        else
        die("Erreur d'ajout de l'employe !!! ");
      } else 
        die("Erreur d'ajout de l'employes !!! ");
    }
    else
    {
        $this->view('employes/add');
    }
    
  }

  //modification
    public function edit($id){
      if($_SERVER['REQUEST_METHOD'] == 'POST'){
        $data = [
          'id' => $id,
          'nom'       =>$_POST["nom"],
          'prenom'    =>$_POST["prenom"],
          'email'     =>$_POST["email"],
          'password'  =>$_POST["password"],
          'id_user'   =>$this->employeModel->getEmployeById($id)->id_user
        ];
        if(($this->employeModel->updateEmploye($data)) && ($this->userModel->updateUser($data))){
          redirect('employes');
        } else 
          die("Erreur de modification de l'employes !!!");
      } else {
        // Obtenir l'employe existante à partir du model
        $employe = $this->employeModel->getEmployeById($id);
        $user = $this->userModel->getUserById($employe->id_user);
        $data = [
          'id' => $id,
          'nom'       =>$employe->nom,
          'prenom'    =>$employe->prenom,
          'email'     =>$user->email
        ];
  
        $this->view('employes/edit', $data);
      }
    }

     //suppression
    public function delete($id){
      // Obtenir l'employe existante à partir du model
      $employe = $this->employeModel->getEmployeById($id);

      if(($this->employeModel->deleteEmploye($id)) && ($this->userModel->deleteUser($employe->id_user))){
        redirect('employes');
      } else {
        die("Erreur de suppression de l'employe !!!");
      }
    }
  }

 


  