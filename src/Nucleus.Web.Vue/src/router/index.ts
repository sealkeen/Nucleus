import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";
import Home from "@/views/Home.vue";
import About from "@/views/About.vue";
import AccountLayout from '@/account/account-layout.vue';
import Login from '@/account/views/login/login';
import AuthStore from '@/stores/auth-store';

const routes: Array<RouteRecordRaw> = [
  { path: "/", component: Home },
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
