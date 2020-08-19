import { Component } from "@angular/core"

//Utilizando um Decorator que vai configurar o ProductComponent
@Component({
  selector: "",
  template: "<html><body>{{ getName() }}</body></html>"
})

//export é como o public no c#
export class ProductComponent {
  public name: string;
  public ReleasedForSale: boolean;

  //Nome de classes começa com letra maiúscula(PascalCase)
  //Nome de variáveis internas e métodos em TypeScript sempre começa com letra minúscula(camelCase)

  public getName(): string {
    return "Samsung";
  }
}
