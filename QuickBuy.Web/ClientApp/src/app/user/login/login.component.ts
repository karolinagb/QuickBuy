import { Component } from "@angular/core";
import { User } from "../../model/user";
import { Router } from "@angular/router";

//Para o typescript entender a classe como component
@Component({
  //Definindo uma tag que pode ser usada para renderizar o LoginComponent
  selector: "app-login",

  //Arquivo html que representa o template do componente:
  templateUrl: "./login.component.html",

  //informando o arquivo de folha de estilo do componente:
  //OBS: Dentro de colchetes pois é uma lista. Posso colocar várias folhas de estilo
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {

  public user = new User();
  
  //Toda vez que LoginComponent é instanciado ele recebe a instância de User
  constructor(private router: Router) {
    this.user = new User();
  }

  logIn() {
    if (this.user.email == "karol@teste.com" && this.user.password == "abc123") {
      localStorage.setItem("user-autenticated", "1");
      //0this.router.navigate(['/'])
    }
  }
}
