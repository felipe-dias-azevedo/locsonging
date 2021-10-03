import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {HomeComponent} from "./home/home.component";
import {FavoriteComponent} from "./favorite/favorite.component";
import {ListeningComponent} from "./listening/listening.component";

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: HomeComponent,
    loadChildren: () => import("./home/home.module").then(m => m.HomeModule),
    //canLoad
  },
  {
    path: 'user',
    loadChildren: () => import('./authentication/authentication.module').then(m => m.AuthenticationModule)
  },
  {
    path: 'search',
    //component:
    loadChildren: () => import('./search/search.module').then(m => m.SearchModule)
  },
  {
    path: 'listening',
    component: ListeningComponent,
    loadChildren: () => import('./listening/listening.module').then(m => m.ListeningModule)
  },
  {
    path: 'libraries',
    loadChildren: () => import("./library/library.module").then(m => m.LibraryModule)
  },
  {
    path: 'favorites',
    component: FavoriteComponent,
    loadChildren: () => import("./favorite/favorite.module").then(m => m.FavoriteModule)
  },
  {
    path: 'artists',
    loadChildren: () => import("./artist/artist.module").then(m => m.ArtistModule)
  },
  {
    path: 'spotify',
    loadChildren: () => import("./spotify/spotify.module").then(m => m.SpotifyModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
