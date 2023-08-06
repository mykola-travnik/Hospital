import { Route } from '@angular/router';

export const routes: Route[] = [
  {
    path: '',
    children: [
      {
        path: 'admin',
        loadComponent: () =>
          import('./pages/main-admin-page/main-admin-page.component').then(
            (c) => c.MainAdminPageComponent
          ),
      },
      {
        path: 'admin-countries',
        loadComponent: () =>
          import(
            './pages/main-admin-page/countries-admin-page/countries-admin-page.component'
          ).then((c) => c.CountriesAdminPageComponent),
      },
    ],
  },
];
