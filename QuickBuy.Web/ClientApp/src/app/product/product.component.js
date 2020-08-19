"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ProductComponent = void 0;
//export é como o public no c#
var ProductComponent = /** @class */ (function () {
    function ProductComponent() {
    }
    //Nome de classes começa com letra maiúscula(PascalCase)
    //Nome de variáveis internas e métodos em TypeScript sempre começa com letra minúscula(camelCase)
    ProductComponent.prototype.getName = function () {
        return this.name;
    };
    return ProductComponent;
}());
exports.ProductComponent = ProductComponent;
//# sourceMappingURL=product.component.js.map