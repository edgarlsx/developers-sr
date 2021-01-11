import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GrupoClientesComponent } from './grupo-clientes.component';

describe('GrupoClientesComponent', () => {
  let component: GrupoClientesComponent;
  let fixture: ComponentFixture<GrupoClientesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GrupoClientesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GrupoClientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
