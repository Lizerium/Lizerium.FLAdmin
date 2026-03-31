import { createFileRoute } from "@tanstack/react-router";
import { routeGuard } from "@/contexts/AuthContext";
import FLAdminSidebar from "@/components/FLAdminSidebar";
import { SidebarInset } from "@/components/ui/sidebar";

export const Route = createFileRoute("/plugin_manager")({
  beforeLoad: routeGuard,
  component: PluginsPage,
});

function PluginsPage() {
  return (
    <main className="flex">
      <FLAdminSidebar />
      <SidebarInset className="flex-1">
        <div>Hello from Plugins!</div>
      </SidebarInset>
    </main>
  );
}
