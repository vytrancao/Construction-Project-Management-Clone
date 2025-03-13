import { NextResponse } from 'next/server';
import type { NextRequest } from 'next/server';
import { auth } from '@/auth';

export async function middleware(request: NextRequest) {
  const session = await auth();
  console.log(session);
  if (!session) {
    return NextResponse.redirect(new URL('/', request.url));
  }
}

export const config = {
  matcher: '/dashboard/:path*',
};