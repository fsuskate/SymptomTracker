import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { SgMedsComponent } from './component/sg-meds.component';
import { SgSymptomsComponent } from './component/sg-symptoms.component';
import { SgSymptomsService } from './service/sg-symptoms.service';

@NgModule({
  declarations: [
    AppComponent,
    SgMedsComponent,
    SgSymptomsComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    HttpClientModule
  ],
  providers: [SgSymptomsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
