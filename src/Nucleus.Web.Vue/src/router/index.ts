import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";
import About from "@/views/About.vue";
import AdminLayout from '@/admin/admin-layout.vue';
import AccountLayout from '@/account/account-layout.vue';
import AuthStore from '@/stores/auth-store';

const routes: Array<RouteRecordRaw> = [
  { path: "/", redirect: '/admin/home' },
  { path: "/about", component: About, meta: { requiresAuth: true }},
  {
    path: "/account", 
    component: AccountLayout, 
    children: [
      { path: 'login', component: require('@/account/views/login/login.vue').default },
      // { path: 'register', component: Register },
      // { path: 'forgot-password', component: ForgotPassword },
      // { path: 'reset-password', component: ResetPassword }
    ]
  },
  {
      path: '/admin',
      component: AdminLayout,
      meta: { requiresAuth: true },
      children: [
          { path: 'home', component: require('@/admin/views/home/home.vue').default },
          // { path: 'user-list', component: require('@/admin/views/users/user-list.vue').default },
          // { path: 'role-list', component: require('@/admin/views/roles/role-list.vue').default }
      ]
  }
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
});

router.beforeEach((to: any, from: any, next: any) => {
  if (to.matched.some((record: any) => record.meta.requiresAuth)) {
    if (!AuthStore.isSignedIn()) {
      next({
        path: '/account/login',
        query: { redirect: to.fullPath }
      });
    }
  }
  next();
});

export default router;
