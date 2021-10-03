import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    //component:
  },
  {
    path: ':id',
    //component:
  },
  {
    path: ':id/albums',
    //component:
  },
  {
    path: ':id/albums/:id',
    //component:
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ArtistRoutingModule { }
