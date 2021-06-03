import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoriasComponent } from './components/categorias/categorias.component';
import { CalendarioComponent } from './components/calendario/calendario.component';
import { CalendarioheaderComponent } from './components/calendarioheader/calendarioheader.component';
import { CategorianuevaComponent } from './components/categorianueva/categorianueva.component';

@NgModule({
  declarations: [
    AppComponent,
    CategoriasComponent,
    CalendarioComponent,
    CalendarioheaderComponent,
    CategorianuevaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), // ToastrModule added
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
