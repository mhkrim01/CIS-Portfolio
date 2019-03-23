import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product-page',
  templateUrl: './product-page.component.html',
  styleUrls: ['./product-page.component.css']
})
export class ProductPageComponent implements OnInit {
  
  testProd = {name: 'test'};
  products: Array<any> = [this.testProd, this.testProd, this.testProd, this.testProd, this.testProd, this.testProd]
  isHovering: boolean = false;

  constructor(private _router: Router) {
    console.log(this.products.length);
   }

  ngOnInit() {
  }

  navigateToProducts(){
    this._router.navigateByUrl('/products');
  }
}
