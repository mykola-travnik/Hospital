import { SpecialisationClient } from 'src/client/client';
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
      {
        path: 'admin-cities',
        loadComponent: () =>
          import(
            './pages/main-admin-page/cities-admin-page/cities-admin-page.component'
          ).then((c) => c.CitiesAdminPageComponent),
      },
      {
        path: 'admin-doctors',
        loadComponent: () =>
          import(
            './pages/main-admin-page/doctors-admin-page/doctors-admin-page.component'
          ).then((c) => c.DoctorsAdminPageComponent),
      },
      {
        path: 'admin-hospitals',
        loadComponent: () =>
          import(
            './pages/main-admin-page/hospitals-admin-page/hospitals-admin-page.component'
          ).then((c) => c.HospitalsAdminPageComponent),
      },
      {
        path: 'admin-specialisations',
        loadComponent: () =>
          import(
            './pages/main-admin-page/specialisations-admin-page/specialisations-admin-page.component'
          ).then((c) => c.SpecialisationsAdminPageComponent),
      },
      {
        path: 'admin-hospitalDoctors',
        loadComponent: () =>
          import(
            './pages/main-admin-page/hospitalDoctors-admin-page/hospitalDoctors-admin-page.component'
          ).then((c) => c.HospitalDoctorsAdminPageComponent),
      },
      {
        path: 'sign-in',
        loadComponent: () =>
          import(
            './pages/sign-in/sign-in.component'
          ).then((c) => c.SignInComponent),
      },
    ],
  },
];
