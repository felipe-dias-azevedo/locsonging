import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {PlayerComponent} from "./player.component";
import {FavoriteComponent} from "./favorite/favorite.component";
import {SearchComponent} from "./search/search.component";
import {LibraryComponent} from "./library/library.component";
import {LibrariesComponent} from "./libraries/libraries.component";
import {HomeComponent} from "./home/home.component";

const routes: Routes = [
  {
    path: '',
    component: PlayerComponent,
    children: [
      {
        path: '',
        component: HomeComponent,
      },
      {
        path: 'search',
        component: SearchComponent
      },
      {
        path: 'libraries',
        component: LibrariesComponent
      },
      {
        path: 'libraries/:id',
        component: LibraryComponent
      },
      {
        path: 'favorites',
        component: FavoriteComponent,
      },
      {
        path: 'artists',

      },
      {
        path: 'artists/:id',
        //component:
      },
      {
        path: 'artists/:id/albums',
        //component:
      },
      {
        path: 'artists/:id/albums/:id',
        //component:
      },
      {
        path: 'spotify',

      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PlayerRoutingModule { }
