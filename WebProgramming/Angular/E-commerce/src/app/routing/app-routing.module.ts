import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { ProductPageComponent } from '../product-page/product-page.component';
import { AboutComponent } from '../about/about.component';
import { ContactPageComponent } from '../contact-page/contact-page.component';
import { OrderPageComponent } from '../order-page/order-page.component';

const routes: Routes = [
  {path: '', redirectTo: '/home', pathMatch: 'full'},
  {path: 'home', component: HomeComponent, pathMatch: 'full'},
  {path: 'products', component: ProductPageComponent, pathMatch: 'full'},
  {path: 'about', component: AboutComponent, pathMatch: 'full' },
  {path: 'contact', component: ContactPageComponent, pathMatch: 'full'},
  {path: 'order', component: OrderPageComponent, pathMatch: 'full'}
]

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule],
  declarations: []
})
export class AppRoutingModule { }
