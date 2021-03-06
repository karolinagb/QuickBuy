import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
  providedIn:'root' //Class GuardRoutes vai ser publicada na raiz
})
export class GuardRoutes implements CanActivate{

  constructor(private router: Router) {
    
  }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean{

      var autenticated = localStorage.getItem("user-autenticated");

      if (autenticated == "1") {
        return true;
      }
      this.router.navigate(['/login'], { queryParams: {returnUrl: state.url} }); //navega para a pagina de autenticação caso o user tente navegar sem estar autenticado
      //se usuario autenticado
      return false;
    }

}
