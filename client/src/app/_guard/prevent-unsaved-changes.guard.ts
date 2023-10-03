import { CanDeactivateFn } from '@angular/router';
import { MemberEditComponent } from '../members/member-edit/member-edit.component';

export const preventUnsavedChangesGuard: CanDeactivateFn<MemberEditComponent> = 
(component) => {
  //const confirmService = inject(ConfirmService);
  
  if (component.editForm?.dirty) {
    return confirm('Are you sure you want to continue?')
  }
  return true;
};