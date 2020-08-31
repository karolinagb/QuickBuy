import { Component } from "@angular/core";

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

}
