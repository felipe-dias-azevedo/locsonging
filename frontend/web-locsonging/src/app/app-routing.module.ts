import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {FavoriteComponent} from "./player/favorite/favorite.component";
import {ListeningComponent} from "./listening/listening.component";

const routes: Routes = [
  {
    path: '',
    loadChildren: () => import("./player/player.module").then(m => m.PlayerModule),
  },
  // {
  //   path: 'user',
  //   loadChildren: () => import('./authentication/authentication.module').then(m => m.AuthenticationModule)
  // },
  // {
  //   path: 'listening',
  //   component: ListeningComponent,
  //   loadChildren: () => import('./listening/listening.module').then(m => m.ListeningModule)
  // },
  // {
  //   path: 'spotify/connect',
  //   //component:
  // }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
